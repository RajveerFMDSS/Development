using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace FMDSS.Infrastructure.CommanModel
{
    /// <summary>
    /// Extension Class Version : 1.0.0.0.0.1
    /// </summary>

    public static class Extension
    {
       
        /// <summary>
        /// Checks DataSet for Null
        /// </summary>
        /// <param name="ds"></param>
        /// <returns>Returns false if DataSet is Null</returns>
        public static bool IsValid(this DataSet ds)
        {
            if (ds!=null && ds.Tables != null && ds.Tables.Count > 0)
                return true;
            return false;
        }

        /// <summary>
        /// Checks DataTable for Null
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>Returns false if DataTable is Null</returns>
        public static bool IsValid(this DataTable dt)
        {
            if (dt!=null && dt.Rows != null && dt.Rows.Count > 0)
                return true;

            return false;
        }

        #region DataRow Extensions
        /// <summary>
        /// Returns a string value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns null if column is DBNull</returns>
        public static string GetString(this DataRow row, string column)
        {
            var i = row.Table.Columns.IndexOf(column);
            string value;
            // column name does not exist or is DBNull
            if (i == -1 || row.IsNull(i))
                value = null;
            // value found and is valid type
            else if (row[column] is string)
                value = (string)row[column];
            // value found but not valid type
            else
                value = Convert.ToString(row[column]);
            return value;
        }

        /// <summary>
        /// Returns a int value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns 0 if column is DBNull</returns>
        public static int GetInt(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);
            int value;
            // column name does not exist or is DBNull
            if (i == -1 || row.IsNull(i))
                value = 0;
            // value found and is valid type
            else if (row[column] is int)
                value = (int)row[column];
            // value found and is "loosely" valid type, perform cast
            else if (row[column] is Int16)
                value = (Int16)row[column];
            // value found and trying to convert it to int
            else if (row[column] is decimal)
            {
                value = Convert.ToInt32(row[column]);
            }
            else if (int.TryParse(Convert.ToString(row[column]), out value))
            {

            }
            // value found but not valid type
            else
                value = -1;
            return value;
        }

        /// <summary>
        /// Returns a decimal value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns 0 if column is DBNull</returns>
        public static decimal GetDecimal(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);
            decimal value;
            // column name does not exist or is DBNull
            if (i == -1 || row.IsNull(i))
                value = 0;
            // value found and is valid type
            else if (row[column] is int)
                decimal.TryParse(row[column].ToString(), out value);
            // value found and is "loosely" valid type, perform cast
            else if (row[column] is Decimal)
                value = (decimal)row[column];
            // value found but not valid type
            else
                value = -1;
            return value;
        }

        /// <summary>
        /// Returns a nullable int value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns 0 if column is DBNull</returns>
        public static int? GetNullableInt(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);
            int? value;
            // column name does not exist or is DBNull
            if (i == -1 || row.IsNull(i))
                value = null;
            // value found and is valid type
            else if (row[column] is int)
                value = (int)row[column];
            // value found and is "loosely" valid type, perform cast
            else if (row[column] is Int16)
                value = (Int16)row[column];
            // value found but not valid type
            else
                value = null;
            return value;
        }

        /// <summary>
        /// Returns a nullable bool value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns 0 if column is DBNull</returns>
        public static bool? GetNullableBool(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);
            bool? value;
            // column name does not exist or is DBNull
            if (i == -1 || row.IsNull(i))
                value = null;
            // value found and is valid type
            else if (row[column] is bool)
                value = (bool)row[column];
            // value found but not valid type
            else
                value = null;
            return value;
        }

        /// <summary>
        /// Returns a nullable DateTime value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns 0 if column is DBNull</returns>
        public static DateTime? GetNullableDateTime(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);
            DateTime? value;
            // column name does not exist or is DBNull
            if (i == -1 || row.IsNull(i))
                value = null;
            // value found and is valid type
            else if (row[column] is DateTime)
                value = (DateTime)row[column];
            // value found but not valid type
            else
                value = null;
            return value;
        }

        /// <summary>
        /// Returns True if the column is null.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool GetIsNull(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);
            return row.IsNull(i);
        }

        /// <summary>
        /// Returns a Double value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns 0 if column is DBNull</returns>
        public static double GetDouble(this DataRow row, string column)
        {
            int index = row.Table.Columns.IndexOf(column);
            double value;
            // column name does not exist or is DBNull
            if (index == -1 || row.IsNull(index))
                value = 0;
            // value found and is valid type
            else if (row[column] is int)
                value = (int)row[column];
            // value found and is "loosely" valid type, perform cast
            else if (row[column] is double)
                value = (double)row[column];
            // value found but not valid type
            else if (double.TryParse(Convert.ToString(row[column]), out value))
            {
            }
            else
                value = -1;
            return value;
        }

        /// <summary>
        /// Returns a bool value from a DataRow.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>Returns false if column is DBNull</returns>
        public static bool GetBool(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);  // column not found || value DBNull  ||  value not valid type
            if (i == -1)
                return false;
            if (row.IsNull(i))
                return false;
            if (row[column] is int && (int)row[column] == 1)
                return true;
            if (row[column] is string && ((string)row[column]).ToLower() == "true")
                return true;
            if (row[column] is string && ((string)row[column]).ToLower() == "false")
                return false;
            if (!(row[column] is bool))
                return false;
            return (bool)row[column];
        }

        public static DateTime GetDateTime(this DataRow row, string column)
        {
            int i = row.Table.Columns.IndexOf(column);                                     // column not found || value DBNull  ||  value not valid type
            if (i == -1)
                return DateTime.MinValue;
            if (row.IsNull(i))
                return DateTime.MinValue;
            if (!(row[column] is DateTime))
                return DateTime.MinValue;
            return (DateTime)row[column];
        }
        #endregion
    }
}