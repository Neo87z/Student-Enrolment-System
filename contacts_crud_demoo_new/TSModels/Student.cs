using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TooSharp.Models
{   
    /// <summary>
    ///  TooSharp Generated Code. Do not Modify 
    ///  Date Genereated: 2021-10-06 8:20 AM
    ///  Author: sheha
    /// </summary>
    /// <seealso cref="TooSharp.Core.ITSRelationShips" />
    [DebuggerStepThrough]
    public class Contacts : TooSharp.Core.ITSModel
    {
      #region CODE
	     public static string TableName = "contacts";
         public string GetTableName() { return TableName; }
         public List<string> GetColumns() {return Enum.GetValues(typeof(COLUMNS)).Cast<COLUMNS>().Select(v => v.ToString()).ToList();  }
         public static TooSharp.Core.TSQueryBuilder<Contact> Records() { return new TooSharp.Core.TSQueryBuilder<Contact>(TooSharp.TSRelationships.getInstance()); }
         public static TooSharp.Core.TSQueryBuilder<Contact> Records(object[] columns) { return new TooSharp.Core.TSQueryBuilder<Contact>(TooSharp.TSRelationships.getInstance(),columns); }
      #endregion
      #region COLUMNS
       public enum COLUMNS
       {
         id,
         reg_id,
         s_name,
         Dob,
         Gender,
         Mobile,
         Course,
         //column
       }
      #endregion
    }
     [DebuggerStepThrough]
    public class Contact: TooSharp.Core.TSmodel 
    {
     
       #region PROPERTIES
         [TSKey]
         public int Id { get; private set; }=-1;
         [TSRequired]
         [TSNotEmpty]
         public int Reg_id { get; set; }
         [TSRequired]
         [TSNotEmpty]
         public string S_name { get; set; }
         [TSRequired]
         [TSNotEmpty]
         public string Dob { get; set; }
         [TSRequired]
         [TSNotEmpty]
         public string Gender { get; set; }
         [TSRequired]
         [TSPhone]
         public string Mobile { get; set; }
         [TSRequired]
         [TSNotEmpty]
         public string Course { get; set; }
         //property
       #endregion
    }
}
