using Game.Interfaces;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Xml;

namespace Game.AppServices
{
    public class IdentityVerificationService : IIdentityVerificationService
    {
        public bool TCQuery(string firstName, string lastName, string tcNumber, int birthYear)
        {
            try
            {

                var uri = new Uri("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx"); // public sorgu adresi

                var request = (HttpWebRequest)WebRequest.CreateDefault(uri); // istek oluşturuyoruz
                                                                             // istek bilgileri
                request.ContentType = "text/xml; charset=utf-8";
                request.Method = "POST";
                request.Accept = "text/xml";
                request.Headers.Add("SOAPAction", "http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula");

                // SOAP xml dosyası ve bilgileri göndereceğimiz XML
                var xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
                      <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"" >         
                               <soap:Body>          
                                  <TCKimlikNoDogrula xmlns=""http://tckimlik.nvi.gov.tr/WS"">           
                                     <TCKimlikNo>" + Convert.ToInt64(tcNumber) + @"</TCKimlikNo>           
                                     <Ad>" + firstName.ToUpper(new CultureInfo("tr-TR", false)) + @"</Ad>           
                                     <Soyad>" + lastName.ToUpper(new CultureInfo("tr-TR", false)) + @"</Soyad>           
                                     <DogumYili>" + Convert.ToInt32(birthYear) + @"</DogumYili>           
                                   </TCKimlikNoDogrula>           
                                 </soap:Body>
                                </soap:Envelope>";

                // xml i okuyoruz
                XmlDocument soapEnvelopeXml = new XmlDocument();
                soapEnvelopeXml.LoadXml(xml);
                // sunucuya istek gönderiyoruz
                using (Stream stream = request.GetRequestStream())
                {
                    soapEnvelopeXml.Save(stream);
                }
                // gelen cevabı burada okuyoruz.
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                    {
                        string soapResult = rd.ReadToEnd(); 
                        return bool.Parse(System.Text.RegularExpressions.Regex.Replace(soapResult, "<.*?>", String.Empty));
                    }
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
