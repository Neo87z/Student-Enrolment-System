using System.Data;
using System.Diagnostics;
namespace TooSharp
{
    [DebuggerStepThrough]
    public  class TSRelationships: TooSharp.Core.ITSRelationShips
    {
           DataTable relationships = null;
       public DataTable getRelationships()
        {
            if (relationships==null)
            {
                relationships = new DataTable();
                relationships.Columns.Add(COLUMNS.TABLE_NAME.ToString());
                relationships.Columns.Add(COLUMNS.COLUMN_NAME.ToString());
                relationships.Columns.Add(COLUMNS.REFERENCED_TABLE_NAME.ToString());
                relationships.Columns.Add(COLUMNS.REFERENCED_COLUMN_NAME.ToString());
                //data

            }
            return relationships;
        }

        public enum COLUMNS
        {

            TABLE_NAME,
            COLUMN_NAME,
            REFERENCED_TABLE_NAME,
            REFERENCED_COLUMN_NAME
        }
       static TSRelationships instance = null;
        public static TSRelationships getInstance()
        {
            if (instance == null) instance = new TSRelationships();
            return instance;
        }
    }
}
