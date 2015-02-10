using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.Odbc;
using System;


namespace OBCConvertedRPC
{
    public class SP_R_PR_OBC_LST : Carnival.ERS.Business.Base.Base
    {
        private char msDelimiter;
        private StringBuilder moSB;

        //public OBCMaintenanceModule()
        //{
        //    MessageBox.Show("testthis");
        //}
        public SP_R_PR_OBC_LST()
        {
            base.msTableName = TABLE_NAME;
        }
        private const string TABLE_NAME = "";

        public string PI_CLIENT_VERSION
        {

            set { mRow["PI-CLIENT-VERSION"] = value; }
            //set { mRow["PI-CLIENT-VERSION"] = value; }
        }
        public string PI_USERID
        {
            set { mRow["PI-USERID"] = value; }
        }
        public string PI_DATE_TIME
        {
            set { mRow["PI-DATE-TIME"] = value; }
        }
        public string PI_APPLICATION_NAME
        {
            set { mRow["PI-APPLICATION-NAME"] = value; }
        }
        public string PI_FORM_NAME
        {
            set { mRow["PI-FORM-NAME"] = value; }
        }
        public string PI_STORED_PROCEDURE_NAME
        {
            set { mRow["PI-STORED-PROCEDURE-NAME"] = value; }
        }

        public string PL_SEC_RULE_CODE_0001
        {

            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 1); }
        }

        public string PL_SEC_RULE_CODE_0002
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 2); }
        }
        public string PL_SEC_RULE_CODE_0003
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 3); }
        }
        public string PL_SEC_RULE_CODE_0004
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 4); }
        }
        public string PL_SEC_RULE_CODE_0005
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 5); }
        }
        public string PL_SEC_RULE_CODE_0006
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 6); }
        }
        public string PL_SEC_RULE_CODE_0007
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 7); }
        }
        public string PL_SEC_RULE_CODE_0008
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 8); }
        }
        public string PL_SEC_RULE_CODE_0009
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 9); }
        }
        public string PL_SEC_RULE_CODE_0010
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 10); }
        }
        public string PL_SEC_RULE_CODE_0011
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 11); }
        }
        public string PL_SEC_RULE_CODE_0012
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 12); }
        }
        public string PL_SEC_RULE_CODE_0013
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 13); }
        }
        public string PL_SEC_RULE_CODE_0014
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 14); }
        }
        public string PL_SEC_RULE_CODE_0015
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 15); }
        }
        public string PL_SEC_RULE_CODE_0016
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 16); }
        }
        public string PL_SEC_RULE_CODE_0017
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 17); }
        }
        public string PL_SEC_RULE_CODE_0018
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 18); }
        }
        public string PL_SEC_RULE_CODE_0019
        {
            set { mRow["PL-SEC-RULE-CODE-001"] = AddData("PL-SEC-RULE-CODE-001", value, 19); }
        }
        public string PL_SEC_RULE_CODE_0020
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 1); }
        }
        public string PL_SEC_RULE_CODE_0021
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 2); }
        }
        public string PL_SEC_RULE_CODE_0022
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 3); }
        }
        public string PL_SEC_RULE_CODE_0023
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 4); }
        }
        public string PL_SEC_RULE_CODE_0024
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 5); }
        }
        public string PL_SEC_RULE_CODE_0025
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 6); }
        }
        public string PL_SEC_RULE_CODE_0026
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 7); }
        }
        public string PL_SEC_RULE_CODE_0027
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 8); }
        }
        public string PL_SEC_RULE_CODE_0028
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 9); }
        }
        public string PL_SEC_RULE_CODE_0029
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 10); }
        }
        public string PL_SEC_RULE_CODE_0030
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 11); }
        }
        public string PL_SEC_RULE_CODE_0031
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 12); }
        }
        public string PL_SEC_RULE_CODE_0032
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 13); }
        }
        public string PL_SEC_RULE_CODE_0033
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 14); }
        }
        public string PL_SEC_RULE_CODE_0034
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 15); }
        }
        public string PL_SEC_RULE_CODE_0035
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 16); }
        }
        public string PL_SEC_RULE_CODE_0036
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 17); }
        }
        public string PL_SEC_RULE_CODE_0037
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 18); }
        }
        public string PL_SEC_RULE_CODE_0038
        {
            set { mRow["PL-SEC-RULE-CODE-002"] = AddData("PL-SEC-RULE-CODE-002", value, 19); }
        }
        public string PL_SEC_RULE_CODE_0039
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 1); }
        }
        public string PL_SEC_RULE_CODE_0040
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 2); }
        }
        public string PL_SEC_RULE_CODE_0041
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 3); }
        }
        public string PL_SEC_RULE_CODE_0042
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 4); }
        }
        public string PL_SEC_RULE_CODE_0043
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 5); }
        }
        public string PL_SEC_RULE_CODE_0044
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 6); }
        }
        public string PL_SEC_RULE_CODE_0045
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 7); }
        }
        public string PL_SEC_RULE_CODE_0046
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 8); }
        }
        public string PL_SEC_RULE_CODE_0047
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 9); }
        }
        public string PL_SEC_RULE_CODE_0048
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 10); }
        }
        public string PL_SEC_RULE_CODE_0049
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 11); }
        }
        public string PL_SEC_RULE_CODE_0050
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 12); }
        }
        public string PL_SEC_RULE_CODE_0051
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 13); }
        }

        public string PL_SEC_RULE_CODE_0052
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 14); }
        }
        public string PL_SEC_RULE_CODE_0053
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 15); }
        }
        public string PL_SEC_RULE_CODE_0054
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 16); }
        }
        public string PL_SEC_RULE_CODE_0055
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 17); }
        }
        public string PL_SEC_RULE_CODE_0056
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 18); }
        }
        public string PL_SEC_RULE_CODE_0057
        {
            set { mRow["PL-SEC-RULE-CODE-003"] = AddData("PL-SEC-RULE-CODE-003", value, 19); }
        }
        public string PL_SEC_RULE_CODE_0058
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 1); }
        }
        public string PL_SEC_RULE_CODE_0059
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 2); }
        }
        public string PL_SEC_RULE_CODE_0060
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 3); }
        }
        public string PL_SEC_RULE_CODE_0061
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 4); }
        }
        public string PL_SEC_RULE_CODE_0062
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 5); }
        }
        public string PL_SEC_RULE_CODE_0063
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 6); }
        }
        public string PL_SEC_RULE_CODE_0064
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 7); }
        }
        public string PL_SEC_RULE_CODE_0065
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 8); }
        }
        public string PL_SEC_RULE_CODE_0066
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 9); }
        }
        public string PL_SEC_RULE_CODE_0067
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 10); }
        }
        public string PL_SEC_RULE_CODE_0068
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 11); }
        }
        public string PL_SEC_RULE_CODE_0069
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 12); }
        }
        public string PL_SEC_RULE_CODE_0070
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 13); }
        }
        public string PL_SEC_RULE_CODE_0071
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 14); }
        }
        public string PL_SEC_RULE_CODE_0072
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 15); }
        }
        public string PL_SEC_RULE_CODE_0073
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 16); }
        }
        public string PL_SEC_RULE_CODE_0074
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 17); }
        }
        public string PL_SEC_RULE_CODE_0075
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 18); }
        }
        public string PL_SEC_RULE_CODE_0076
        {
            set { mRow["PL-SEC-RULE-CODE-004"] = AddData("PL-SEC-RULE-CODE-004", value, 19); }
        }
        public string PL_SEC_RULE_CODE_0077
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 1); }
        }
        public string PL_SEC_RULE_CODE_0078
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 2); }
        }
        public string PL_SEC_RULE_CODE_0079
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 3); }
        }
        public string PL_SEC_RULE_CODE_0080
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 4); }
        }
        public string PL_SEC_RULE_CODE_0081
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 5); }
        }
        public string PL_SEC_RULE_CODE_0082
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 6); }
        }
        public string PL_SEC_RULE_CODE_0083
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 7); }
        }
        public string PL_SEC_RULE_CODE_0084
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 8); }
        }
        public string PL_SEC_RULE_CODE_0085
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 9); }
        }
        public string PL_SEC_RULE_CODE_0086
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 10); }
        }
        public string PL_SEC_RULE_CODE_0087
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 11); }
        }
        public string PL_SEC_RULE_CODE_0088
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 12); }
        }
        public string PL_SEC_RULE_CODE_0089
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 13); }
        }
        public string PL_SEC_RULE_CODE_0090
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 14); }
        }
        public string PL_SEC_RULE_CODE_0091
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 15); }
        }
        public string PL_SEC_RULE_CODE_0092
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 16); }
        }
        public string PL_SEC_RULE_CODE_0093
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 17); }
        }
        public string PL_SEC_RULE_CODE_0094
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 18); }
        }
        public string PL_SEC_RULE_CODE_0095
        {
            set { mRow["PL-SEC-RULE-CODE-005"] = AddData("PL-SEC-RULE-CODE-005", value, 19); }
        }
        public string PL_SEC_RULE_CODE_0096
        {
            set { mRow["PL-SEC-RULE-CODE-006"] = AddData("PL-SEC-RULE-CODE-006", value, 1); }
        }
        public string PL_SEC_RULE_CODE_0097
        {
            set { mRow["PL-SEC-RULE-CODE-006"] = AddData("PL-SEC-RULE-CODE-006", value, 2); }
        }
        public string PL_SEC_RULE_CODE_0098
        {
            set { mRow["PL-SEC-RULE-CODE-006"] = AddData("PL-SEC-RULE-CODE-006", value, 3); }
        }
        public string PL_SEC_RULE_CODE_0099
        {
            set { mRow["PL-SEC-RULE-CODE-006"] = AddData("PL-SEC-RULE-CODE-006", value, 4); }
        }
        public string PL_SEC_RULE_CODE_0100
        {
            set { mRow["PL-SEC-RULE-CODE-006"] = AddData("PL-SEC-RULE-CODE-006", value, 5); }
        }
        public string PL_SEC_RULE_DATA_0001
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 1); }
        }
        public string PL_SEC_RULE_DATA_0002
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 2); }
        }
        public string PL_SEC_RULE_DATA_0003
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 3); }
        }
        public string PL_SEC_RULE_DATA_0004
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 4); }
        }
        public string PL_SEC_RULE_DATA_0005
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 5); }
        }
        public string PL_SEC_RULE_DATA_0006
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 6); }
        }
        public string PL_SEC_RULE_DATA_0007
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 7); }
        }
        public string PL_SEC_RULE_DATA_0008
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 8); }
        }
        public string PL_SEC_RULE_DATA_0009
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 9); }
        }
        public string PL_SEC_RULE_DATA_0010
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 10); }
        }
        public string PL_SEC_RULE_DATA_0011
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 11); }
        }
        public string PL_SEC_RULE_DATA_0012
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 12); }
        }
        public string PL_SEC_RULE_DATA_0013
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 13); }
        }
        public string PL_SEC_RULE_DATA_0014
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 14); }
        }
        public string PL_SEC_RULE_DATA_0015
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 15); }
        }
        public string PL_SEC_RULE_DATA_0016
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 16); }
        }
        public string PL_SEC_RULE_DATA_0017
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 17); }
        }
        public string PL_SEC_RULE_DATA_0018
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 18); }
        }
        public string PL_SEC_RULE_DATA_0019
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 19); }
        }
        public string PL_SEC_RULE_DATA_0020
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 20); }
        }
        public string PL_SEC_RULE_DATA_0021
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 21); }
        }
        public string PL_SEC_RULE_DATA_0022
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 22); }
        }
        public string PL_SEC_RULE_DATA_0023
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 23); }
        }
        public string PL_SEC_RULE_DATA_0024
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 24); }
        }
        public string PL_SEC_RULE_DATA_0025
        {
            set { mRow["PL-SEC-RULE-DATA-001"] = AddData("PL-SEC-RULE-DATA-001", value, 25); }
        }
        public string PL_SEC_RULE_DATA_0026
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 1); }
        }
        public string PL_SEC_RULE_DATA_0027
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 2); }
        }
        public string PL_SEC_RULE_DATA_0028
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 3); }
        }
        public string PL_SEC_RULE_DATA_0029
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 4); }
        }
        public string PL_SEC_RULE_DATA_0030
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 5); }
        }
        public string PL_SEC_RULE_DATA_0031
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 6); }
        }
        public string PL_SEC_RULE_DATA_0032
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 7); }
        }
        public string PL_SEC_RULE_DATA_0033
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 8); }
        }
        public string PL_SEC_RULE_DATA_0034
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 9); }
        }
        public string PL_SEC_RULE_DATA_0035
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 10); }
        }
        public string PL_SEC_RULE_DATA_0036
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 11); }
        }
        public string PL_SEC_RULE_DATA_0037
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 12); }
        }
        public string PL_SEC_RULE_DATA_0038
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 13); }
        }
        public string PL_SEC_RULE_DATA_0039
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 14); }
        }
        public string PL_SEC_RULE_DATA_0040
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 15); }
        }
        public string PL_SEC_RULE_DATA_0041
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 16); }
        }
        public string PL_SEC_RULE_DATA_0042
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 17); }
        }
        public string PL_SEC_RULE_DATA_0043
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 18); }
        }
        public string PL_SEC_RULE_DATA_0044
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 19); }
        }
        public string PL_SEC_RULE_DATA_0045
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 20); }
        }
        public string PL_SEC_RULE_DATA_0046
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 21); }
        }
        public string PL_SEC_RULE_DATA_0047
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 22); }
        }
        public string PL_SEC_RULE_DATA_0048
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 23); }
        }
        public string PL_SEC_RULE_DATA_0049
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 24); }
        }
        public string PL_SEC_RULE_DATA_0050
        {
            set { mRow["PL-SEC-RULE-DATA-002"] = AddData("PL-SEC-RULE-DATA-002", value, 25); }
        }
        public string PL_SEC_RULE_DATA_0051
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 1); }
        }
        public string PL_SEC_RULE_DATA_0052
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 2); }
        }
        public string PL_SEC_RULE_DATA_0053
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 3); }
        }
        public string PL_SEC_RULE_DATA_0054
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 4); }
        }
        public string PL_SEC_RULE_DATA_0055
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 5); }
        }
        public string PL_SEC_RULE_DATA_0056
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 6); }
        }
        public string PL_SEC_RULE_DATA_0057
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 7); }
        }
        public string PL_SEC_RULE_DATA_0058
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 8); }
        }
        public string PL_SEC_RULE_DATA_0059
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 9); }
        }
        public string PL_SEC_RULE_DATA_0060
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 10); }
        }
        public string PL_SEC_RULE_DATA_0061
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 11); }
        }
        public string PL_SEC_RULE_DATA_0062
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 12); }
        }
        public string PL_SEC_RULE_DATA_0063
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 13); }
        }
        public string PL_SEC_RULE_DATA_0064
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 14); }
        }
        public string PL_SEC_RULE_DATA_0065
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 15); }
        }
        public string PL_SEC_RULE_DATA_0066
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 16); }
        }
        public string PL_SEC_RULE_DATA_0067
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 17); }
        }
        public string PL_SEC_RULE_DATA_0068
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 18); }
        }
        public string PL_SEC_RULE_DATA_0069
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 19); }
        }
        public string PL_SEC_RULE_DATA_0070
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 20); }
        }
        public string PL_SEC_RULE_DATA_0071
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 21); }
        }
        public string PL_SEC_RULE_DATA_0072
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 22); }
        }
        public string PL_SEC_RULE_DATA_0073
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 23); }
        }
        public string PL_SEC_RULE_DATA_0074
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 24); }
        }
        public string PL_SEC_RULE_DATA_0075
        {
            set { mRow["PL-SEC-RULE-DATA-003"] = AddData("PL-SEC-RULE-DATA-003", value, 25); }
        }
        public string PL_SEC_RULE_DATA_0076
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 1); }
        }
        public string PL_SEC_RULE_DATA_0077
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 2); }
        }
        public string PL_SEC_RULE_DATA_0078
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 3); }
        }
        public string PL_SEC_RULE_DATA_0079
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 4); }
        }
        public string PL_SEC_RULE_DATA_0080
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 5); }
        }
        public string PL_SEC_RULE_DATA_0081
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 6); }
        }
        public string PL_SEC_RULE_DATA_0082
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 7); }
        }
        public string PL_SEC_RULE_DATA_0083
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 8); }
        }
        public string PL_SEC_RULE_DATA_0084
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 9); }
        }
        public string PL_SEC_RULE_DATA_0085
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 10); }
        }
        public string PL_SEC_RULE_DATA_0086
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 11); }
        }
        public string PL_SEC_RULE_DATA_0087
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 12); }
        }
        public string PL_SEC_RULE_DATA_0088
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 13); }
        }
        public string PL_SEC_RULE_DATA_0089
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 14); }
        }
        public string PL_SEC_RULE_DATA_0090
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 15); }
        }
        public string PL_SEC_RULE_DATA_0091
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 16); }
        }
        public string PL_SEC_RULE_DATA_0092
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 17); }
        }
        public string PL_SEC_RULE_DATA_0093
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 18); }
        }
        public string PL_SEC_RULE_DATA_0094
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 19); }
        }
        public string PL_SEC_RULE_DATA_0095
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 20); }
        }
        public string PL_SEC_RULE_DATA_0096
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 21); }
        }
        public string PL_SEC_RULE_DATA_0097
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 22); }
        }
        public string PL_SEC_RULE_DATA_0098
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 23); }
        }
        public string PL_SEC_RULE_DATA_0099
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 24); }
        }
        public string PL_SEC_RULE_DATA_0100
        {
            set { mRow["PL-SEC-RULE-DATA-004"] = AddData("PL-SEC-RULE-DATA-004", value, 25); }
        }
        public string OBC_CODE
        {
            set { mRow["OBC-CODE"] = value; }
        }
        public string INTERFACE_TYPE
        {
            set { mRow["INTERFACE-TYPE"] = value; }
        }
        public string STATUS_CODE
        {
            set { mRow["STATUS-CODE"] = value; }
        }
        public string PAYMENT_TYPE
        {
            set { mRow["PAYMENT-TYPE"] = value; }
        }
        public string PAY_CALC_METHOD
        {
            set { mRow["PAY-CALC-METHOD"] = value; }
        }
        public string SEC_DEPT_CODE
        {
            set { mRow["SEC-DEPT-CODE"] = value; }
        }
        public string SEC_FUNCTION_CODE
        {
            set { mRow["SEC-FUNCTION-CODE"] = value; }
        }
        public int SEC_LEVEL_CODE
        {
            set { mRow["SEC-LEVEL-CODE"] = value; }
        }
        // Conversion issue changed to System.DBNULL.Value
        public string PO_DATE_TIME
        {
            get
            {
                if (object.ReferenceEquals(mRow["PO-DATE-TIME"], System.DBNull.Value))
                {
                    return "";
                }
                else
                {
                    return (mRow["PO-DATE-TIME"].ToString());
                }
            }
            set
            {
                if (string.Concat("", value).Length == 0)
                {
                    mRow["PO-DATE-TIME"] = " ";
                }
                else
                {
                    mRow["PO-DATE-TIME"] = value;
                }
            }
        }

        public override void BuildDataTable()
        {
            //Conversion  Chr(30) to (char)30
            // Odbc.OdbcType.Char to System.Data.Odbc.OdbcType.Char
            DataColumn oCol;
            moSB = new StringBuilder();
            msDelimiter = (char)30;

            oCol = new DataColumn();
            oCol.ColumnName = "PI-CLIENT-VERSION";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 8);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PI-USERID";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 15);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PI-DATE-TIME";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 16);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PI-APPLICATION-NAME";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 30);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PI-FORM-NAME";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 30);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PI-STORED-PROCEDURE-NAME";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 30);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-CODE-001";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 247);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-CODE-001"] = moSB.Append(msDelimiter, 19).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-CODE-002";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 247);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-CODE-002"] = moSB.Append(msDelimiter, 19).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-CODE-003";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 247);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-CODE-003"] = moSB.Append(msDelimiter, 19).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-CODE-004";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 247);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-CODE-004"] = moSB.Append(msDelimiter, 19).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-CODE-005";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 247);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-CODE-005"] = moSB.Append(msDelimiter, 19).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-CODE-006";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 65);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-CODE-006"] = moSB.Append(msDelimiter, 5).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-DATA-001";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 250);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-DATA-001"] = moSB.Append(msDelimiter, 25).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-DATA-002";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 250);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-DATA-002"] = moSB.Append(msDelimiter, 25).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-DATA-003";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 250);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-DATA-003"] = moSB.Append(msDelimiter, 25).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "PL-SEC-RULE-DATA-004";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 250);
            moTable.Columns.Add(oCol);
            moSB.Remove(0, moSB.Length);
            mRow["PL-SEC-RULE-DATA-004"] = moSB.Append(msDelimiter, 25).ToString();

            oCol = new DataColumn();
            oCol.ColumnName = "OBC-CODE";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 4);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "INTERFACE-TYPE";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 1);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "STATUS-CODE";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 1);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PAYMENT-TYPE";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 1);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PAY-CALC-METHOD";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 1);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "SEC-DEPT-CODE";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 2);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "SEC-FUNCTION-CODE";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 2);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "SEC-LEVEL-CODE";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 1);
            oCol.ExtendedProperties.Add("Size", 1);
            moTable.Columns.Add(oCol);

            oCol = new DataColumn();
            oCol.ColumnName = "PO-DATE-TIME";
            oCol.ExtendedProperties.Add("Type", System.Data.Odbc.OdbcType.Char);
            oCol.ExtendedProperties.Add("Direction", 3);
            oCol.ExtendedProperties.Add("Size", 16);
            moTable.Columns.Add(oCol);

        }

        public class RS_PR_OBC_LST
        {
            //Conversion Changed Name from RS_PR_OBC_LST to RS_PR_OBC_LST_Value
            public static string RS_PR_OBC_LST_Value
            {
                get { return "RS-PR-OBC-LST"; }
            }
            public static string OBC_CODE
            {
                get { return "OBC-CODE"; }
            }
            public static string INTERFACE_TYPE
            {
                get { return "INTERFACE-TYPE"; }
            }
            public static string REFUND_IND
            {
                get { return "REFUND-IND"; }
            }
            public static string STATUS_CODE
            {
                get { return "STATUS-CODE"; }
            }
            public static string PAYMENT_TYPE
            {
                get { return "PAYMENT-TYPE"; }
            }
            public static string PAY_CALC_METHOD
            {
                get { return "PAY-CALC-METHOD"; }
            }
            public static string CREATION_DATE
            {
                get { return "CREATION-DATE"; }
            }
            public static string CLOSED_DATE
            {
                get { return "CLOSED-DATE"; }
            }
            public static string USER_ID
            {
                get { return "USER-ID"; }
            }
            public static string OBC_TITLE
            {
                get { return "OBC-TITLE"; }
            }
        }

        public class Tables
        {
            public static string RS_PR_OBC_LST
            {
                get { return "RS-PR-OBC-LST"; }
            }
        }
        // Conversion Changed from int16 to int
        private string AddData(string ParameterToAppend, string value, int iPos)
        {
            string sInputParameterString = (string)mRow[ParameterToAppend];
            string[] asParameters = sInputParameterString.Split(msDelimiter); // Conversion Split
            asParameters[iPos - 1] = value;
            string sOutputParameterString = String.Join(msDelimiter.ToString(), asParameters); // Conversion Join
            return sOutputParameterString;
        }
        // Conversion Changed from int16 to int
        //private string PadData(string value, int iLength, int iPrecision, bool bSigned)
        //{
        //    string part1 = "";
        //    string part2 = "";
        //    string sign = "";
        //    char c = '.';
        //    if (value.Contains(".") == true) {
        //        part1 = value.Split(c)(0);
        //        if (part1.Contains("-") == true) {
        //            part1 = part1.Substring(1);
        //            sign = "-";
        //        } else {
        //            sign = " ";
        //        }
        //        if (bSigned == false) {
        //            sign = "";
        //        }
        //        part2 = value.Split(".")(1);
        //        part1 = sign + part1.PadLeft(iLength, "0");
        //        part2 = part2.PadRight(iPrecision, "0");
        //        part1 = part1 + "." + part2;
        //    } else if (iPrecision > 0) {
        //        part1 = value;
        //        if (part1.Contains("-") == true) {
        //            part1 = part1.Substring(1);
        //            sign = "-";
        //        } else {
        //            sign = " ";
        //        }
        //        if (bSigned == false) {
        //            sign = "";
        //        }
        //        part1 = sign + part1.PadLeft(iLength, "0");
        //        part2 = part2.PadRight(iPrecision, "0");
        //        part1 = part1 + "." + part2;
        //    } else {
        //        part1 = value;
        //        if (part1.Contains("-") == true) {
        //            part1 = part1.Substring(1);
        //            sign = "-";
        //        } else {
        //            sign = " ";
        //        }
        //        if (bSigned == false) {
        //            sign = "";
        //        }
        //        part1 = sign + part1.PadLeft(iLength, "0");
        //    }
        //    return part1;
        //}

    }
}
