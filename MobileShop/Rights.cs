using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop
{
    class Rights
    {
        private static bool superUser = false;
        public static bool SuperUser
        {
            get
            {
                return superUser;
            }
            set
            {
                superUser = value;
            }
        }
        public static bool CheckSuper(String Password)
        {
            if (String.Compare(Password.ToUpper(), "IFAQ") == 0)
            {
                SuperUser = true;
                return true;
            }
            else return false;
        } 
        public static bool Access(int RDRMID, String FormName)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                string Compare = "";
                Compare = SQL.ScalarQuery("Select Access From TvuFormRights where RoleID=" + RDRMID + " AND FormName='" + FormName + "'");
                if (string.Compare("True", Compare) == 0) return true;
                else return false;
            }
        }
        public static bool Add(int RDRMID, String FormName)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                string Compare = "";
                Compare = SQL.ScalarQuery("Select Add1 From TvuFormRights where RoleID=" + RDRMID + " AND FormName='" + FormName + "'");
                if (string.Compare("True", Compare) == 0) return true;
                else return false;
            }
        }
        public static bool Edit(int RDRMID, String FormName)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                string Compare = "";
                Compare = SQL.ScalarQuery("Select Edit1 From TvuFormRights where RoleID=" + RDRMID + " AND FormName='" + FormName + "'");
                if (string.Compare("True", Compare) == 0) return true;
                else return false;
            }
        }
        public static bool Delete(int RDRMID, String FormName)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                string Compare = "";
                Compare = SQL.ScalarQuery("Select Delete1 From TvuFormRights where RoleID=" + RDRMID + " AND FormName='" + FormName + "'");
                if (string.Compare("True", Compare) == 0) return true;
                else return false;
            }
        }
        public static bool Print(int RDRMID, String FormName)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                string Compare = "";
                Compare = SQL.ScalarQuery("Select Print1 From TvuFormRights where RoleID=" + RDRMID + " AND FormName='" + FormName + "'");
                if (string.Compare("True", Compare) == 0) return true;
                else return false;
            }
        }
        private static bool checkRecord(string type, int RDRMID, int formID)
        {

            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                string Compare = "";
                Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT " + type + " FROM RoleDetail  WHERE Formid=" + formID + " and RDRMID=" + RDRMID + ") THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
                if (string.Compare("True", Compare) == 0) return true;
                else return false;
            }
        }
        public static bool getAccess(int RDRMID, int FormId)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                bool result = false;
                if (checkRecord("Access", RDRMID, FormId) == true)
                {
                    string Compare = "";
                    Compare = SQL.ScalarQuery("Select Access From RoleDetail where RDRMID=" + RDRMID + " AND FormId=" + FormId + "");
                    if (string.Compare("True", Compare) == 0)
                    {
                        result = true;
                    }
                }
                return result;
            }
        }
        public static bool getEdit(int RDRMID, int FormId)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                bool result = false;
                if (checkRecord("Edit1", RDRMID, FormId) == true)
                {
                    string Compare = "";
                    Compare = SQL.ScalarQuery("Select Edit1 From RoleDetail where RDRMID=" + RDRMID + " AND FormId=" + FormId + "");
                    if (string.Compare("True", Compare) == 0)
                    {
                        result = true;
                    }
                }
                return result;
            }
        }
        public static bool getAdd(int RDRMID, int FormId)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                bool result = false;
                if (checkRecord("Add1", RDRMID, FormId) == true)
                {
                    string Compare = "";
                    Compare = SQL.ScalarQuery("Select Add1 From RoleDetail where RDRMID=" + RDRMID + " AND FormId=" + FormId + "");
                    if (string.Compare("True", Compare) == 0)
                    {
                        result = true;
                    }
                }
                return result;
            }
        }
        public static bool getDelete(int RDRMID, int FormId)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                bool result = false;
                if (checkRecord("Delete1", RDRMID, FormId) == true)
                {
                    string Compare = "";
                    Compare = SQL.ScalarQuery("Select Delete1 From RoleDetail where RDRMID=" + RDRMID + " AND FormId=" + FormId + "");
                    if (string.Compare("True", Compare) == 0)
                    {
                        result = true;
                    }
                }
                return result;
            }
        }
        public static bool CheckForm(int RDRMID, int FormId1)
        {
            if (SuperUser == true)
            {
                return true;
            }
            else
            {
                string Compare = "";
                Compare = SQL.ScalarQuery("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM RoleDetail  WHERE RDRMID=" + RDRMID + " and FormId=" + FormId1 + ") THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
                if (string.Compare("True", Compare) == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
