using HDFCAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net;


namespace HDFCAPI.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage POSTDATA([FromBody] List<HDFCPARAMETERMODEL> CustomerObj)
        {
            try
            {
                response objResponse = new response();
                DataTable Customer = new DataTable();

                Customer.Columns.Add("QUOTE_NO", typeof(string));
                Customer.Columns.Add("LEAD_ID", typeof(string));
                Customer.Columns.Add("CREATED_TIMESTAMP", typeof(string));
                Customer.Columns.Add("CREATED_DATE", typeof(string));
                Customer.Columns.Add("F_SOURCE", typeof(string));
                Customer.Columns.Add("F_AGENCY_CODE", typeof(string));
                Customer.Columns.Add("F_CURRENT_STEP", typeof(string));
                Customer.Columns.Add("F_DISCLAIMER_CHECK", typeof(string));
                Customer.Columns.Add("APPLICATION_NUMBER", typeof(string));
                Customer.Columns.Add("POLICY_NO", typeof(string));
                Customer.Columns.Add("LA_CLIENT_CODE", typeof(string));
                Customer.Columns.Add("PRODUCT_CODE", typeof(string));
                Customer.Columns.Add("LA_TITLE", typeof(string));
                Customer.Columns.Add("LA_FIRST_NAME", typeof(string));
                Customer.Columns.Add("LA_LAST_NAME", typeof(string));
                Customer.Columns.Add("LA_MOBILE", typeof(string));
                Customer.Columns.Add("LA_EMAIL_ID", typeof(string));
                Customer.Columns.Add("LA_GENDER", typeof(string));
                Customer.Columns.Add("LA_ADDR1", typeof(string));
                Customer.Columns.Add("LA_STREET", typeof(string));
                Customer.Columns.Add("LA_AREA", typeof(string));
                Customer.Columns.Add("LA_CITY", typeof(string));
                Customer.Columns.Add("LA_STATE", typeof(string));
                Customer.Columns.Add("LA_PINCODE", typeof(string));
                Customer.Columns.Add("F_LA1_DOB", typeof(string));
                Customer.Columns.Add("SMOKER", typeof(string));
                Customer.Columns.Add("ANNUAL_PREMIUM", typeof(string));
                Customer.Columns.Add("TOTAL_ANNUAL_PREMIUM_WITH_TAX", typeof(string));
                Customer.Columns.Add("TAX_AMOUNT", typeof(string));
                Customer.Columns.Add("TERM", typeof(string));
                Customer.Columns.Add("F_PREMIUM_TERM", typeof(string));
                Customer.Columns.Add("SUM_ASSURED", typeof(string));
                Customer.Columns.Add("F_BILLING_FREQUENCY", typeof(string));
                Customer.Columns.Add("OCCUPATION_TYPE", typeof(string));
                Customer.Columns.Add("PAYMENT_STATUS", typeof(string));
                Customer.Columns.Add("PAYMENT_MODE", typeof(string));
                Customer.Columns.Add("PAYMENT_DATE", typeof(string));
                Customer.Columns.Add("PAYMENT_TIMESTAMP", typeof(string));
                Customer.Columns.Add("URL", typeof(string));
                Customer.Columns.Add("F_PPH_FIRST_NAME", typeof(string));
                Customer.Columns.Add("F_PPH_LAST_NAME", typeof(string));
                Customer.Columns.Add("F_PPH_EMAIL", typeof(string));
                Customer.Columns.Add("F_PPH_GENDER", typeof(string));
                Customer.Columns.Add("F_PPH_CITY", typeof(string));
                Customer.Columns.Add("F_PPH_MOBILE", typeof(string));
                Customer.Columns.Add("F_PPH_DOB", typeof(string));
                Customer.Columns.Add("TEBT_PRODUCT_CD", typeof(string));
                Customer.Columns.Add("PLAN_CODE", typeof(string));
                Customer.Columns.Add("COMBO_FLG", typeof(string));
                Customer.Columns.Add("COMBO_PROD_CD", typeof(string));
                Customer.Columns.Add("CHAILD_COMBO_PROD_CD", typeof(string));
                Customer.Columns.Add("CHAILD_APP_NO", typeof(string));
                Customer.Columns.Add("PLAN_OPTION", typeof(string));
                Customer.Columns.Add("NRI_FLAG", typeof(string));
                Customer.Columns.Add("MODIFIED_DATE", typeof(string));
                Customer.Columns.Add("F_PPH_PINCODE", typeof(string));
                Customer.Columns.Add("F_PPH_STATE", typeof(string));
                Customer.Columns.Add("TOPUP_FLAG", typeof(string));
                Customer.Columns.Add("TOPUP_PERCENTAGE", typeof(string));
                Customer.Columns.Add("ISSUE_DATE", typeof(string));
                Customer.Columns.Add("HEALTH_ISSUE_DATE", typeof(string));
                Customer.Columns.Add("RENEWAL_DATE", typeof(string));
                Customer.Columns.Add("PAYOUT_DATE", typeof(string));
                Customer.Columns.Add("PAYOUT_AMOUNT", typeof(string));
                Customer.Columns.Add("MARITAL_STATUS", typeof(string));
                Customer.Columns.Add("ANNUAL_INCOME", typeof(string));
                Customer.Columns.Add("CRM_INTIMATED", typeof(string));
                Customer.Columns.Add("LEAD_TRIGGER_REASON", typeof(string));
                Customer.Columns.Add("SUCCESS_FLG", typeof(string));
                Customer.Columns.Add("CRM_INTIMATED_DATE_TIME", typeof(string));
                Customer.Columns.Add("CALL_CENTER_NAME", typeof(string));
                Customer.Columns.Add("SENT_DATE_TIME", typeof(string));
                Customer.Columns.Add("LEAD_TYPE", typeof(string));
                Customer.Columns.Add("CHANNEL", typeof(string));
                Customer.Columns.Add("SOURCE_CATEGORY", typeof(string));
                Customer.Columns.Add("PRODUCT_NAME", typeof(string));



                for (int j = 0; j < CustomerObj.Count; j++)
                {
                    Customer.Rows.Add(CustomerObj[j].QUOTE_NO,
                        CustomerObj[j].LEAD_ID, CustomerObj[j].CREATED_TIMESTAMP, CustomerObj[j].CREATED_DATE,
                        CustomerObj[j].F_SOURCE, CustomerObj[j].F_AGENCY_CODE, CustomerObj[j].F_CURRENT_STEP, CustomerObj[j].F_DISCLAIMER_CHECK
                  , CustomerObj[j].APPLICATION_NUMBER, CustomerObj[j].POLICY_NO, CustomerObj[j].LA_CLIENT_CODE, CustomerObj[j].PRODUCT_CODE,
                        CustomerObj[j].LA_TITLE, CustomerObj[j].LA_FIRST_NAME, CustomerObj[j].LA_LAST_NAME, CustomerObj[j].LA_MOBILE
                  , CustomerObj[j].LA_EMAIL_ID, CustomerObj[j].LA_GENDER, CustomerObj[j].LA_ADDR1, CustomerObj[j].LA_STREET, CustomerObj[j].LA_AREA,
                        CustomerObj[j].LA_CITY, CustomerObj[j].LA_STATE, CustomerObj[j].F_LA1_DOB, CustomerObj[j].LA_PINCODE

                  , CustomerObj[j].SMOKER, CustomerObj[j].ANNUAL_PREMIUM, CustomerObj[j].TOTAL_ANNUAL_PREMIUM_WITH_TAX, CustomerObj[j].TAX_AMOUNT,
                        CustomerObj[j].TERM, CustomerObj[j].F_PREMIUM_TERM, CustomerObj[j].SUM_ASSURED, CustomerObj[j].F_BILLING_FREQUENCY
                  , CustomerObj[j].OCCUPATION_TYPE, CustomerObj[j].PAYMENT_STATUS, CustomerObj[j].PAYMENT_MODE, CustomerObj[j].PAYMENT_DATE,
                        CustomerObj[j].PAYMENT_TIMESTAMP, CustomerObj[j].URL, CustomerObj[j].F_PPH_FIRST_NAME, CustomerObj[j].F_PPH_LAST_NAME
                  , CustomerObj[j].F_PPH_EMAIL, CustomerObj[j].F_PPH_GENDER, CustomerObj[j].F_PPH_CITY, CustomerObj[j].F_PPH_MOBILE,
                        CustomerObj[j].F_PPH_DOB, CustomerObj[j].TEBT_PRODUCT_CD, CustomerObj[j].PLAN_CODE, CustomerObj[j].COMBO_FLG
                  , CustomerObj[j].COMBO_PROD_CD, CustomerObj[j].CHAILD_COMBO_PROD_CD, CustomerObj[j].CHAILD_APP_NO,

                        CustomerObj[j].PLAN_OPTION,
                        CustomerObj[j].NRI_FLAG, CustomerObj[j].MODIFIED_DATE, CustomerObj[j].F_PPH_PINCODE, CustomerObj[j].F_PPH_STATE,
                        CustomerObj[j].TOPUP_FLAG
                  , CustomerObj[j].TOPUP_PERCENTAGE, CustomerObj[j].ISSUE_DATE, CustomerObj[j].HEALTH_ISSUE_DATE, CustomerObj[j].RENEWAL_DATE,
                        CustomerObj[j].PAYOUT_DATE,
                        CustomerObj[j].PAYOUT_AMOUNT, CustomerObj[j].MARITAL_STATUS, CustomerObj[j].ANNUAL_INCOME, CustomerObj[j].CRM_INTIMATED,
                        CustomerObj[j].LEAD_TRIGGER_REASON
                  , CustomerObj[j].SUCCESS_FLG, CustomerObj[j].CRM_INTIMATED_DATE_TIME, CustomerObj[j].CALL_CENTER_NAME, CustomerObj[j].SENT_DATE_TIME,
                        CustomerObj[j].LEAD_TYPE, CustomerObj[j].CHANNEL, CustomerObj[j].SOURCE_CATEGORY, CustomerObj[j].PRODUCT_NAME);
                }
                string QN = "", LI = "", CRTM = "", CRDT = "", FS = "", FAC = "", FCS = "", FDC = "", AN = "", PN = "", LCD = "", PD = "", LT = "", LFN = "", LLN = "", LM = ""
                    , LEI = "", LG = "", LA = "", LS = "", LAA = "", LCC = "", LSS = "", LP = "", S = "", AP = "", TAPWT = "", TA = "", T = "", FPT = "", SA = "", FBF
                    , OT = "", PS = "", PM = "", PDD = "", PT = "", U = "", FPFN = "", FPLN = "", FPE = ""
                    , FPG = "", FPC = "", FPM = "", FPD = "", TPC = "", PC = "", CF = "", CPD = "", CCPC = "", CAN = "", PO = "", NF = "", MD = "", FPS = ""
                    , TF = "", TP = "", HID = "", RD = "", PDDD = "", PA = "", AI = "", CI = ""
                    , LTR = "", SF = "", CIDT = "", CCN = "", SDT = "", LTT = "", C = "", SC = "", PNN = "",ID="",MS="",FPP="",LD="";
                MySqlConnection constr = new MySqlConnection("server = 172.16.0.86; user id = root; database = test1; password = '1234';");
                {
                    for (int i = 0; i < CustomerObj.Count; i++)
                    {
                        QN = CustomerObj[i].QUOTE_NO;
                        LI = CustomerObj[i].LEAD_ID;
                        CRTM = CustomerObj[i].CREATED_TIMESTAMP;
                        CRDT = CustomerObj[i].CREATED_DATE;
                        FS = CustomerObj[i].F_SOURCE;
                        FAC = CustomerObj[i].F_AGENCY_CODE;
                        FCS = CustomerObj[i].F_CURRENT_STEP;
                        FDC = CustomerObj[i].F_DISCLAIMER_CHECK;
                        AN = CustomerObj[i].APPLICATION_NUMBER;
                        PN = CustomerObj[i].POLICY_NO;
                        LCD = CustomerObj[i].LA_CLIENT_CODE;
                        PD = CustomerObj[i].PRODUCT_CODE;
                        LT = CustomerObj[i].LA_TITLE;
                        LFN = CustomerObj[i].LA_FIRST_NAME;
                        LLN = CustomerObj[i].LA_LAST_NAME;
                        LM = CustomerObj[i].LA_MOBILE;
                        LEI = CustomerObj[i].LA_EMAIL_ID;
                        LG = CustomerObj[i].LA_GENDER;
                        LA = CustomerObj[i].LA_ADDR1;
                        LS = CustomerObj[i].LA_STREET;
                        LAA = CustomerObj[i].LA_AREA;
                        LCC = CustomerObj[i].LA_CITY;
                        LSS = CustomerObj[i].LA_STATE;
                        LP = CustomerObj[i].LA_PINCODE;
                        LD = CustomerObj[i].F_LA1_DOB;
                        S = CustomerObj[i].SMOKER;
                        AP = CustomerObj[i].ANNUAL_PREMIUM;
                        TAPWT = CustomerObj[i].TOTAL_ANNUAL_PREMIUM_WITH_TAX;
                        TA = CustomerObj[i].TAX_AMOUNT;
                        T = CustomerObj[i].TERM;
                        FPT = CustomerObj[i].F_PREMIUM_TERM;
                        SA = CustomerObj[i].SUM_ASSURED;
                        FBF = CustomerObj[i].F_BILLING_FREQUENCY;
                        OT = CustomerObj[i].OCCUPATION_TYPE;
                        PS = CustomerObj[i].PAYMENT_STATUS;
                        PM = CustomerObj[i].PAYMENT_MODE;
                        PDD = CustomerObj[i].PAYMENT_DATE;
                        PT = CustomerObj[i].PAYMENT_TIMESTAMP;
                        U = CustomerObj[i].URL;
                        FPFN = CustomerObj[i].F_PPH_FIRST_NAME;
                        FPLN = CustomerObj[i].F_PPH_LAST_NAME;
                        FPE = CustomerObj[i].F_PPH_EMAIL;
                        FPG = CustomerObj[i].F_PPH_GENDER;
                        FPC = CustomerObj[i].F_PPH_CITY;
                        FPM = CustomerObj[i].F_PPH_MOBILE;
                        FPD = CustomerObj[i].F_PPH_DOB;
                        TPC = CustomerObj[i].TEBT_PRODUCT_CD;
                        PC = CustomerObj[i].PLAN_CODE;
                        CF = CustomerObj[i].COMBO_FLG;
                        CPD = CustomerObj[i].COMBO_PROD_CD;
                        CCPC = CustomerObj[i].CHAILD_COMBO_PROD_CD;
                        CAN = CustomerObj[i].CHAILD_APP_NO;
                        PO = CustomerObj[i].PLAN_OPTION;
                        NF = CustomerObj[i].NRI_FLAG;
                        MD = CustomerObj[i].MODIFIED_DATE;
                        FPS = CustomerObj[i].F_PPH_PINCODE;
                        FPP = CustomerObj[i].F_PPH_STATE;
                        TF = CustomerObj[i].TOPUP_FLAG;
                        TP = CustomerObj[i].TOPUP_PERCENTAGE;
                        ID = CustomerObj[i].ISSUE_DATE;
                        HID = CustomerObj[i].HEALTH_ISSUE_DATE;
                        RD = CustomerObj[i].RENEWAL_DATE;
                        PDDD = CustomerObj[i].PAYOUT_DATE;
                        PA = CustomerObj[i].PAYOUT_AMOUNT;
                        MS = CustomerObj[i].MARITAL_STATUS;
                        AI = CustomerObj[i].ANNUAL_INCOME;
                        CI = CustomerObj[i].CRM_INTIMATED;
                        LTR = CustomerObj[i].LEAD_TRIGGER_REASON;
                        SF = CustomerObj[i].SUCCESS_FLG;
                        CIDT = CustomerObj[i].CRM_INTIMATED_DATE_TIME;
                        CCN = CustomerObj[i].CALL_CENTER_NAME;
                        SDT = CustomerObj[i].SENT_DATE_TIME;
                        LTT = CustomerObj[i].LEAD_TYPE;
                        C = CustomerObj[i].CHANNEL;
                        SC = CustomerObj[i].SOURCE_CATEGORY;
                        PNN = CustomerObj[i].PRODUCT_NAME;

                        MySqlCommand cmd = new MySqlCommand("INSERT",constr);
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                           
                        cmd.Parameters.AddWithValue("@QUOTE_NO", QN);
                        cmd.Parameters.AddWithValue("@LEAD_ID", LI);
                        cmd.Parameters.AddWithValue("@CREATED_TIMESTAMP", CRTM);
                        cmd.Parameters.AddWithValue("@CREATED_DATE", CRDT);
                        cmd.Parameters.AddWithValue("@F_SOURCE", FS);
                        cmd.Parameters.AddWithValue("@F_AGENCY_CODE", FAC);
                        cmd.Parameters.AddWithValue("@F_CURRENT_STEP", FCS);
                        cmd.Parameters.AddWithValue("@F_DISCLAIMER_CHECK", FDC);
                        cmd.Parameters.AddWithValue("@APPLICATION_NUMBER", AN);
                        cmd.Parameters.AddWithValue("@POLICY_NO", PN);
                        cmd.Parameters.AddWithValue("@LA_CLIENT_CODE", LCD);
                        cmd.Parameters.AddWithValue("@PRODUCT_CODE", PD);
                        cmd.Parameters.AddWithValue("@LA_TITLE", LT);
                        cmd.Parameters.AddWithValue("@LA_FIRST_NAME", LFN);
                        cmd.Parameters.AddWithValue("@LA_LAST_NAME", LLN);
                        cmd.Parameters.AddWithValue("@LA_MOBILE", LM);
                        cmd.Parameters.AddWithValue("@LA_EMAIL_ID", LEI);
                        cmd.Parameters.AddWithValue("@LA_GENDER", LG);
                        cmd.Parameters.AddWithValue("@LA_ADDR1", LA);
                        cmd.Parameters.AddWithValue("@LA_STREET", LS);
                        cmd.Parameters.AddWithValue("@LA_AREA", LAA);
                        cmd.Parameters.AddWithValue("@LA_CITY", LCC);
                        cmd.Parameters.AddWithValue("@LA_STATE", LSS);
                        cmd.Parameters.AddWithValue("@LA_PINCODE", LP);
                        cmd.Parameters.AddWithValue("@F_LA1_DOB", LD);
                        cmd.Parameters.AddWithValue("@SMOKER", S);
                        cmd.Parameters.AddWithValue("@ANNUAL_PREMIUM", AP);
                        cmd.Parameters.AddWithValue("@TOTAL_ANNUAL_PREMIUM_WITH_TAX", TAPWT);
                        cmd.Parameters.AddWithValue("@TAX_AMOUNT", TA);
                        cmd.Parameters.AddWithValue("@TERM", T);
                        cmd.Parameters.AddWithValue("@F_PREMIUM_TERM", FPT);
                        cmd.Parameters.AddWithValue("@SUM_ASSURED", SA);
                        cmd.Parameters.AddWithValue("@F_BILLING_FREQUENCY", FBF);
                        cmd.Parameters.AddWithValue("@OCCUPATION_TYPE", OT);
                        cmd.Parameters.AddWithValue("@PAYMENT_STATUS", PS);
                        cmd.Parameters.AddWithValue("@PAYMENT_MODE", PM);
                        cmd.Parameters.AddWithValue("@PAYMENT_DATE", PDD);
                        cmd.Parameters.AddWithValue("@PAYMENT_TIMESTAMP", PT);
                        cmd.Parameters.AddWithValue("@URL", U);
                        cmd.Parameters.AddWithValue("@F_PPH_FIRST_NAME", FPFN);
                        cmd.Parameters.AddWithValue("@F_PPH_LAST_NAME", FPLN);
                        cmd.Parameters.AddWithValue("@F_PPH_EMAIL", FPE);
                        cmd.Parameters.AddWithValue("@F_PPH_GENDER", FPG);
                        cmd.Parameters.AddWithValue("@F_PPH_CITY", FPC);
                        cmd.Parameters.AddWithValue("@F_PPH_MOBILE", FPM);
                        cmd.Parameters.AddWithValue("@F_PPH_DOB", FPD);
                        cmd.Parameters.AddWithValue("@TEBT_PRODUCT_CD", TPC);
                        cmd.Parameters.AddWithValue("@PLAN_CODE", PC);
                        cmd.Parameters.AddWithValue("@COMBO_FLG", CF);
                        cmd.Parameters.AddWithValue("@COMBO_PROD_CD", CPD);
                        cmd.Parameters.AddWithValue("@CHAILD_COMBO_PROD_CD", CCPC);
                        cmd.Parameters.AddWithValue("@CHAILD_APP_NO", CAN);
                        cmd.Parameters.AddWithValue("@PLAN_OPTION", PO);
                        cmd.Parameters.AddWithValue("@NRI_FLAG", NF);
                        cmd.Parameters.AddWithValue("@MODIFIED_DATE", MD);
                        cmd.Parameters.AddWithValue("@F_PPH_PINCODE", FPS);
                        cmd.Parameters.AddWithValue("@F_PPH_STATE", FPP);
                        cmd.Parameters.AddWithValue("@TOPUP_FLAG", TF);
                        cmd.Parameters.AddWithValue("@TOPUP_PERCENTAGE", TP);
                        cmd.Parameters.AddWithValue("@ISSUE_DATE", ID);
                        cmd.Parameters.AddWithValue("@HEALTH_ISSUE_DATE", HID);
                        cmd.Parameters.AddWithValue("@RENEWAL_DATE", RD);
                        cmd.Parameters.AddWithValue("@PAYOUT_DATE", PDDD);
                        cmd.Parameters.AddWithValue("@PAYOUT_AMOUNT", PA);
                        cmd.Parameters.AddWithValue("@MARITAL_STATUS", MS);
                        cmd.Parameters.AddWithValue("@ANNUAL_INCOME", AI);
                        cmd.Parameters.AddWithValue("@CRM_INTIMATED", CI);
                        cmd.Parameters.AddWithValue("@LEAD_TRIGGER_REASON", LTR);
                        cmd.Parameters.AddWithValue("@SUCCESS_FLG", SF);
                        cmd.Parameters.AddWithValue("@CRM_INTIMATED_DATE_TIME", CIDT);
                        cmd.Parameters.AddWithValue("@CALL_CENTER_NAME", CCN);
                        cmd.Parameters.AddWithValue("@SENT_DATE_TIME", SDT);
                        cmd.Parameters.AddWithValue("@LEAD_TYPE", LTT);
                        cmd.Parameters.AddWithValue("@CHANNEL", C);
                        cmd.Parameters.AddWithValue("@SOURCE_CATEGORY", SC);
                        cmd.Parameters.AddWithValue("@PRODUCT_NAME", PNN);
                        constr.Open();
                        cmd.ExecuteNonQuery();
                        int ss = cmd.ExecuteNonQuery();
                        constr.Close();

                        if (ss > 0)
                        {
                            objResponse.MESSAGE_CODE = "001-" + LI;
                            break;
                        }
                        else
                        {
                            objResponse.MESSAGE_CODE = "002-FAILED";
                            return Request.CreateResponse(HttpStatusCode.InternalServerError, objResponse, "application/json");
                        }
                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK, objResponse, "application/json");
            }
            catch (Exception ex)
            {
                response objResponse = new response();
                objResponse.MESSAGE_CODE = "002-FAILED";
                return Request.CreateResponse(HttpStatusCode.InternalServerError, objResponse, "application/json");
            }
        }


    }
}
