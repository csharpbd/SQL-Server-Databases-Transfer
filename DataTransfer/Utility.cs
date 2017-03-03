using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataTransfer
{
    public class Utility
    {
        public DataTable GetTableData(string Sql, string ConnectionString)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand selectCommand = new SqlCommand(Sql, con);
                DataSet dataSet = new DataSet();
                new SqlDataAdapter(selectCommand).Fill(dataSet);
                DataTable table = dataSet.Tables[0];
                return table;
            }
            catch (Exception)
            {
                return new DataTable();
            }
            finally
            {
                con.Close();
            }
        }

        public string GetTableScript(string TableName, string ConnectionString)
        {
            string Script = "";

            string Sql = "declare @table varchar(100)" + Environment.NewLine +
            "set @table = '" + TableName + "' " + Environment.NewLine +
                //"-- set table name here" +
            "declare @sql table(s varchar(1000), id int identity)" + Environment.NewLine +
            " " + Environment.NewLine +
                //"-- create statement" +
            "insert into  @sql(s) values ('create table [' + @table + '] (')" + Environment.NewLine +
            " " + Environment.NewLine +
                //"-- column list" +
            "insert into @sql(s)" + Environment.NewLine +
            "select " + Environment.NewLine +
            "    '  ['+column_name+'] ' + " + Environment.NewLine +
            "    data_type + coalesce('('+cast(character_maximum_length as varchar)+')','') + ' ' +" + Environment.NewLine +
            "    case when exists ( " + Environment.NewLine +
            "        select id from syscolumns" + Environment.NewLine +
            "        where object_name(id)=@table" + Environment.NewLine +
            "        and name=column_name" + Environment.NewLine +
            "        and columnproperty(id,name,'IsIdentity') = 1 " + Environment.NewLine +
            "    ) then" + Environment.NewLine +
            "        'IDENTITY(' + " + Environment.NewLine +
            "        cast(ident_seed(@table) as varchar) + ',' + " + Environment.NewLine +
            "        cast(ident_incr(@table) as varchar) + ')'" + Environment.NewLine +
            "    else ''" + Environment.NewLine +
            "   end + ' ' +" + Environment.NewLine +
            "    ( case when IS_NULLABLE = 'No' then 'NOT ' else '' end ) + 'NULL ' + " + Environment.NewLine +
            "    coalesce('DEFAULT '+COLUMN_DEFAULT,'') + ','" + Environment.NewLine +
            " " + Environment.NewLine +
            " from information_schema.columns where table_name = @table" + Environment.NewLine +
            " order by ordinal_position" + Environment.NewLine +
            " " + Environment.NewLine +
                //"-- primary key" +
            "declare @pkname varchar(100)" + Environment.NewLine +
            "select @pkname = constraint_name from information_schema.table_constraints" + Environment.NewLine +
            "where table_name = @table and constraint_type='PRIMARY KEY'" + Environment.NewLine +
            " " + Environment.NewLine +
            "if ( @pkname is not null ) begin" + Environment.NewLine +
            "    insert into @sql(s) values('  PRIMARY KEY (')" + Environment.NewLine +
            "    insert into @sql(s)" + Environment.NewLine +
            "        select '   ['+COLUMN_NAME+'],' from information_schema.key_column_usage" + Environment.NewLine +
            "        where constraint_name = @pkname" + Environment.NewLine +
            "        order by ordinal_position" + Environment.NewLine +
                //"    -- remove trailing comma" +
            "    update @sql set s=left(s,len(s)-1) where id=@@identity" + Environment.NewLine +
            "    insert into @sql(s) values ('  )')" + Environment.NewLine +
            "end" + Environment.NewLine +
            "else begin" + Environment.NewLine +
                //"    -- remove trailing comma" +
            "    update @sql set s=left(s,len(s)-1) where id=@@identity" + Environment.NewLine +
            "end" + Environment.NewLine +
            " " + Environment.NewLine +
            "-- closing bracket" + Environment.NewLine +
            "insert into @sql(s) values( ')' )" + Environment.NewLine +
            " " + Environment.NewLine +
                //"-- result!" +
            "select s from @sql order by id";

            DataTable dt = GetTableData(Sql, ConnectionString);
            foreach (DataRow row in dt.Rows)
            {
                Script += row[0].ToString() + Environment.NewLine;
            }

            return Script;
        }

        public string GetIdentityColumn(string TableName, string ConnectionString)
        {
            string result = "";

            string SQL = "" +
                " SELECT " + Environment.NewLine +
                "c.COLUMN_NAME " + Environment.NewLine +
                "FROM " + Environment.NewLine +
                "INFORMATION_SCHEMA.COLUMNS AS c JOIN " + Environment.NewLine +
                "INFORMATION_SCHEMA.TABLES AS t " + Environment.NewLine +
                "ON t.TABLE_NAME = c.TABLE_NAME " + Environment.NewLine +
                "WHERE " + Environment.NewLine +
                "COLUMNPROPERTY(OBJECT_ID(c.TABLE_NAME),c.COLUMN_NAME,'IsIdentity') = 1 AND t.TABLE_NAME='admin'";
            result = ExecuteScalar(SQL, ConnectionString).ToString();
            return result;
        }

        public string GetSPScript(string SPName, string ConnectionString)
        {
            string Script = "";

            string Sql = "sp_helptext '" + SPName + "'";

            DataTable dt = GetTableData(Sql, ConnectionString);
            foreach (DataRow row in dt.Rows)
            {
                Script += row[0].ToString() + Environment.NewLine;
            }

            return Script;
        }

        public void ExecuteQuery(string Sql, string ConnectionString)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand queryCommand = new SqlCommand(Sql, con);
                queryCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public object ExecuteScalar(string Sql, string ConnectionString)
        {
            object result = new object();
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand queryCommand = new SqlCommand(Sql, con);
                result= queryCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
