using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using StanbicIBTC.BotServices.Models;

namespace StanbicIBTC.BotServices.Utility
{
    public class App
    {
        public static string GetRedboxBalanceEnquiryPayload(BalanceEnquiry balanceEnquiry)
        {
            string channel = ConfigurationManager.AppSettings["channel"];
            string payload = "";
            Random reqTranId = new Random();
            try
            {
                payload = "<soapenv:Envelope xmlns: soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns: soap =\"http://soap.request.manager.redbox.stanbic.com/\">" +
                            "<soapenv:Header/>" +
                            "<soapenv:Body>" +
                            "<soap:request>" +
                            "<channel>" + channel + "</channel>" +
                            "<type>BALANCE_ENQUIRY</type>" +
                            "<customerId>" + balanceEnquiry.CustomerId + "</customerId>" +
                            "<customerIdType>" + balanceEnquiry.CustomerIdType + "</customerIdType>" +
                            "<submissionTime>" + balanceEnquiry.SubmissionTime + "</submissionTime>" +
                            "<reqTranId>" + reqTranId.Next(100000, 999999) + "</reqTranId>" +
                            "<body>" +
                            "<![CDATA[" +
                                "<otherRequestDetails>" +
                                "<passId>" + balanceEnquiry.PassId + "</passId>" +
                                "<passIdType>" + balanceEnquiry.PassIdType + "</passIdType>" +
                                "<passCodeType>" + balanceEnquiry.PassCodeType + "</passCodeType>" +
                                "<passCode>" + balanceEnquiry.PassCode + "</passCode>" +
                                "</otherRequestDetails>" +
                            "]]>" +
                            "</body>" +
                            "</soap:request>" +
                            "</soapenv:Body>";
            }
            catch
            {
                throw;
            }
            return payload;
        }

        public static string GetRedboxFetchBvnPayload(FetchBvn fetchbvn)
        {
            string channel = ConfigurationManager.AppSettings["channel"];
            string payload = "";
            Random reqTranId = new Random();
            try
            {
                payload = "<soapenv:Envelope xmlns: soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns: soap =\"http://soap.request.manager.redbox.stanbic.com/\">" +
                            "<soapenv:Header/>" +
                            "<soapenv:Body>" +
                            "<soap:request>" +
                            "<channel>" + channel + "</channel>" +
                            "<type>FETCH_BVN</type>" +
                            "<customerId>" + fetchbvn.CustomerId + "</customerId>" +
                            "<customerIdType>" + fetchbvn.CustomerIdType + "</customerIdType>" +
                            "<submissionTime>" + fetchbvn.SubmissionTime + "</submissionTime>" +
                            "<reqTranId>" + reqTranId.Next(100000, 999999) + "</reqTranId>" +
                            "<body>" +
                            "<![CDATA[" +
                                "<otherRequestDetails>" +
                                "<passId>" + fetchbvn.PassId + "</passId>" +
                                "<passIdType>" + fetchbvn.PassIdType + "</passIdType>" +
                                "<passCodeType>" + fetchbvn.PassCodeType + "</passCodeType>" +
                                "<passCode>" + fetchbvn.PassCode + "</passCode>" +
                                "</otherRequestDetails>" +
                            "]]>" +
                            "</body>" +
                            "</soap:request>" +
                            "</soapenv:Body>";
            }
            catch
            {
                throw;
            }
            return payload;
        }

        public static string GetRedboxRequestChequeBookPayload(ChequeBook chequebook)
        {
            string channel = ConfigurationManager.AppSettings["channel"];
            string payload = "";
            Random reqTranId = new Random();
            try
            {
                payload = "<soapenv:Envelope xmlns: soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns: soap =\"http://soap.request.manager.redbox.stanbic.com/\">" +
                            "<soapenv:Header/>" +
                            "<soapenv:Body>" +
                            "<soap:request>" +
                            "<channel>" + channel + "</channel>" +
                            "<type>REQUEST_CHEQUE_BOOK</type>" +
                            "<customerId>" + chequebook.CustomerId + "</customerId>" +
                            "<customerIdType>" + chequebook.CustomerIdType + "</customerIdType>" +
                            "<submissionTime>" + chequebook.SubmissionTime + "</submissionTime>" +
                            "<reqTranId>" + reqTranId.Next(100000, 999999) + "</reqTranId>" +
                            "<body>" +
                            "<![CDATA[" +
                                "<otherRequestDetails>" +
                                "<passId>" + chequebook.PassId + "</passId>" +
                                "<passIdType>" + chequebook.PassIdType + "</passIdType>" +
                                "<passCodeType>" + chequebook.PassCodeType + "</passCodeType>" +
                                "<passCode>" + chequebook.PassCode + "</passCode>" +
                                "</otherRequestDetails>" +
                            "]]>" +
                            "</body>" +
                            "</soap:request>" +
                            "</soapenv:Body>";
            }
            catch
            {
                throw;
            }
            return payload;
        }

        public static string GetRedboxStopChequeBookPayload(ChequeBook chequebook)
        {
            string channel = ConfigurationManager.AppSettings["channel"];
            string payload = "";
            Random reqTranId = new Random();
            try
            {
                payload = "<soapenv:Envelope xmlns: soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns: soap =\"http://soap.request.manager.redbox.stanbic.com/\">" +
                            "<soapenv:Header/>" +
                            "<soapenv:Body>" +
                            "<soap:request>" +
                            "<channel>" + channel + "</channel>" +
                            "<type>STOP_CHEQUE</type>" +
                            "<customerId>" + chequebook.CustomerId + "</customerId>" +
                            "<customerIdType>" + chequebook.CustomerIdType + "</customerIdType>" +
                            "<submissionTime>" + chequebook.SubmissionTime + "</submissionTime>" +
                            "<reqTranId>" + reqTranId.Next(100000, 999999) + "</reqTranId>" +
                            "<body>" +
                            "<![CDATA[" +
                                "<otherRequestDetails>" +
                                "<passId>" + chequebook.PassId + "</passId>" +
                                "<passIdType>" + chequebook.PassIdType + "</passIdType>" +
                                "<passCodeType>" + chequebook.PassCodeType + "</passCodeType>" +
                                "<passCode>" + chequebook.PassCode + "</passCode>" +
                                "</otherRequestDetails>" +
                            "]]>" +
                            "</body>" +
                            "</soap:request>" +
                            "</soapenv:Body>";
            }
            catch
            {
                throw;
            }
            return payload;
        }

        public static string GetRedboxRequestCardPayload(Card card)
        {
            string channel = ConfigurationManager.AppSettings["channel"];
            string payload = "";
            Random reqTranId = new Random();
            try
            {
                payload = "<soapenv:Envelope xmlns: soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns: soap =\"http://soap.request.manager.redbox.stanbic.com/\">" +
                            "<soapenv:Header/>" +
                            "<soapenv:Body>" +
                            "<soap:request>" +
                            "<channel>" + channel + "</channel>" +
                            "<type>REQUEST_CARD</type>" +
                            "<customerId>" + card.CustomerId + "</customerId>" +
                            "<customerIdType>" + card.CustomerIdType + "</customerIdType>" +
                            "<submissionTime>" + card.SubmissionTime + "</submissionTime>" +
                            "<reqTranId>" + reqTranId.Next(100000, 999999) + "</reqTranId>" +
                            "<body>" +
                            "<![CDATA[" +
                                "<otherRequestDetails>" +
                                "<passId>" + card.PassId + "</passId>" +
                                "<passIdType>" + card.PassIdType + "</passIdType>" +
                                "<passCodeType>" + card.PassCodeType + "</passCodeType>" +
                                "<passCode>" + card.PassCode + "</passCode>" +
                                "</otherRequestDetails>" +
                            "]]>" +
                            "</body>" +
                            "</soap:request>" +
                            "</soapenv:Body>";
            }
            catch
            {
                throw;
            }
            return payload;
        }

        public static string GetRedboxFreezeAccountPayload(FreezeAccount freezeAccount)
        {
            string channel = ConfigurationManager.AppSettings["channel"];
            string payload = "";
            Random reqTranId = new Random();
            try
            {
                payload = "<soapenv:Envelope xmlns: soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns: soap =\"http://soap.request.manager.redbox.stanbic.com/\">" +
                            "<soapenv:Header/>" +
                            "<soapenv:Body>" +
                            "<soap:request>" +
                            "<channel>" + channel + "</channel>" +
                            "<type>FREEZE_ACCOUNT</type>" +
                            "<customerId>" + freezeAccount.CustomerId + "</customerId>" +
                            "<customerIdType>" + freezeAccount.CustomerIdType + "</customerIdType>" +
                            "<submissionTime>" + freezeAccount.SubmissionTime + "</submissionTime>" +
                            "<reqTranId>" + reqTranId.Next(100000, 999999) + "</reqTranId>" +
                            "<body>" +
                            "<![CDATA[" +
                                "<otherRequestDetails>" +
                                "<passId>" + freezeAccount.PassId + "</passId>" +
                                "<passIdType>" + freezeAccount.PassIdType + "</passIdType>" +
                                "<passCodeType>" + freezeAccount.PassCodeType + "</passCodeType>" +
                                "<passCode>" + freezeAccount.PassCode + "</passCode>" +
                                "</otherRequestDetails>" +
                            "]]>" +
                            "</body>" +
                            "</soap:request>" +
                            "</soapenv:Body>";
            }
            catch
            {
                throw;
            }
            return payload;
        }

        public static string GetRedboxAccountStatementPayload(AccountStatement accountstatement)
        {
            string channel = ConfigurationManager.AppSettings["channel"];
            string payload = "";
            Random reqTranId = new Random();
            try
            {
                payload = "<soapenv:Envelope xmlns: soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns: soap =\"http://soap.request.manager.redbox.stanbic.com/\">" +
                            "<soapenv:Header/>" +
                            "<soapenv:Body>" +
                            "<soap:request>" +
                            "<channel>" + channel + "</channel>" +
                            "<type>ACCOUNT_STATEMENT</type>" +
                            "<customerId>" + accountstatement.CustomerId + "</customerId>" +
                            "<customerIdType>" + accountstatement.CustomerIdType + "</customerIdType>" +
                            "<submissionTime>" + accountstatement.SubmissionTime + "</submissionTime>" +
                            "<reqTranId>" + reqTranId.Next(100000, 999999) + "</reqTranId>" +
                            "<body>" +
                            "<![CDATA[" +
                                "<otherRequestDetails>" +
                                "<sessionId>" + accountstatement.SessionId + "</sessionId>" +
                                "<accountNumber>" + accountstatement.AccountNumber + "</accountNumber>" +
                                "<startDate>" + accountstatement.StartDate + "</startDate>" +
                                "<endDate>" + accountstatement.EndDate + "</endDate>" +
                                "<fileType>" + accountstatement.FileType + "</fileType>" +
                                
                                "<passId>" + accountstatement.PassId + "</passId>" +
                                "<passIdType>" + accountstatement.PassIdType + "</passIdType>" +
                                "<passCodeType>" + accountstatement.PassCodeType + "</passCodeType>" +
                                "<passCode>" + accountstatement.PassCode + "</passCode>" +
                                "</otherRequestDetails>" +
                            "]]>" +
                            "</body>" +
                            "</soap:request>" +
                            "</soapenv:Body>";
            }
            catch
            {
                throw;
            }
            return payload;
        }

        public static string CallRedbox(string dataString)
        {
            string RdbUrl = ConfigurationManager.AppSettings["RdbUrl"];
            string AuthorizationCode = ConfigurationManager.AppSettings["AuthorizationCode"];
            string ModuleID = ConfigurationManager.AppSettings["ModuleID"];
            string soapAction = ConfigurationManager.AppSettings["soapAction"];

            string serverResponse = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            System.IO.Stream dataStream = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(RdbUrl);
                request.Headers.Add("SOAPAction", soapAction);
                request.Headers.Add("Authorization", string.Concat("Basic", " ", AuthorizationCode));
                request.Headers.Add("Module_ID", ModuleID);
                request.ContentType = "text/xml;charset=\"utf-8\"";
                request.Method = "POST";
                //ByPassCertificateError();

                //supress unsigned certificate
                //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(IgnoreCertificateErrorHandler);

                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.WriteLine(dataString);
                    writer.Close();

                    // Send the data to the webserver
                    using (response = (HttpWebResponse)request.GetResponse())
                    {
                        using (dataStream = response.GetResponseStream())
                        {
                            using (StreamReader streamReader = new StreamReader(dataStream))
                            {
                                serverResponse = streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (WebException webEx)
            {
                throw webEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //dataStream.Close();
                //response.Close();
            }
            return serverResponse;
        }
    }
}