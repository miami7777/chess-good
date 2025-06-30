
using System.Net;
using System.Net.Mail;

namespace CG.EmailService
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    var basicCredential = new NetworkCredential("u535883", "a3e789zbbkyz");
                    using (MailMessage Mmessage = new MailMessage())
                    {
                        MailAddress fromAddress = new MailAddress("admin@chess-good.ru");

                        smtpClient.Host = "smtp-15.1gb.ru";
                        smtpClient.Port = 25;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = basicCredential;

                        Mmessage.From = fromAddress;
                        Mmessage.Subject = subject;
                        // Set IsBodyHtml to true means you can send HTML email.
                        Mmessage.IsBodyHtml = true;
                        Mmessage.Body = "<style>.cl_571470 a{\r\noutline-color:invert;\r\noutline-style:none;\r\noutline-width:medium;\r\ncolor:#0faafa;\r\ntext-decoration:none;\r\n}.cl_571470 a img{\r\nborder-top-color:currentColor;\r\nborder-top-style:none;\r\nborder-top-width:medium;\r\nborder-right-color:currentColor;\r\nborder-right-style:none;\r\nborder-right-width:medium;\r\nborder-bottom-color:currentColor;\r\nborder-bottom-style:none;\r\nborder-bottom-width:medium;\r\nborder-left-color:currentColor;\r\nborder-left-style:none;\r\nborder-left-width:medium;\r\n}.cl_571470 table td{\r\n}.cl_571470 .ExternalClass_mr_css_attr, .cl_571470 .ExternalClass_mr_css_attr a, .cl_571470 .ExternalClass_mr_css_attr span, .cl_571470 .ExternalClass_mr_css_attr b, .cl_571470 .ExternalClass_mr_css_attr br, .cl_571470 .ExternalClass_mr_css_attr p, .cl_571470 .ExternalClass_mr_css_attr div{\r\nline-height:inherit;\r\n}</style>\r\n<table style=\"margin: 0 auto;background: #e5e5e5;min-width:320px;\" cellpadding=\"0\" cellspacing=\"0\">\r\n      <tbody>\r\n        <tr>\r\n          <td>\r\n            <table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\">\r\n              <tbody>\r\n                <tr>\r\n                  <td style=\"text-align: center\" valign=\"top\">\r\n                    <a href=\"https://chess-good.ru/\" style=\"text-decoration:none;\" target=\"_blank\" rel=\" noopener noreferrer\">\r\n                      <img src=\"\" alt=\"ChessGood\" style=\"width: 600px;height: 240px;\">\r\n                    </a>\r\n                  </td>\r\n                </tr>\r\n              </tbody>\r\n            </table>\r\n          </td>\r\n        </tr>\r\n      </tbody>\r\n    </table>\r\n<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"background-color: #c4c4c4;margin: 0 auto\">\r\n      <tbody>\r\n        <tr>\r\n          <td style=\"background: #e5e5e5\">\r\n            <table style=\"background-color: #fff;padding: 20px 40px;margin: 0 auto;margin-top: 20px;\" width=\"550px;\">\r\n              <tbody>\r\n                <tr style=\"margin: 20px 83px\">\r\n                  <td class=\"article-title_mr_css_attr\" style=\"font-family: Arial, Helvetica, sans-serif;font-size: 17px;font-weight: 400;\" valign=\"top\">\r\n                    <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\">\r\n                      \r\n                        <tbody><tr>\r\n                          <td style=\"padding:0 0 15px;font:1rem/1.5 Calibri, Arial, Helvetica, sans-serif;color:#1e1e1e;\">\r\n "+ message+"                                                   </td>\r\n                        </tr>\r\n                    </tbody></table>\r\n                  </td>\r\n                </tr>\r\n              </tbody>\r\n            </table>\r\n          </td>\r\n        </tr>\r\n        <tr style=\"background-color: #eaeaea;\">\r\n          <td>\r\n            <table width=\"100%\" style=\"text-align: center;margin-bottom: 20px;margin-top: 20px;\">\r\n              <tbody style=\"background: #e5e5e5\">\r\n                <tr>\r\n                  <td style=\"background-color: #eaeaea\">\r\n                      <a href=\"https://miami-chess.ru/\" style=\"text-decoration:none;margin-right: 15px;\" target=\"_blank\" rel=\" noopener noreferrer\">\r\n                        <img src=\"\" width=\"24\" style=\"vertical-align:top;font:12px/16px Arial, Helvetica, sans-serif;color:#9fb3ce;\" alt=\"ico\">\r\n                      </a>\r\n                      <a href=\""+ @BaseConfiguration.Telegram + "\" style=\"text-decoration:none;margin-right: 15px;\" target=\"_blank\" rel=\" noopener noreferrer\">\r\n                        <img src=\"\" width=\"24\" style=\"vertical-align:top;\" alt=\"Telegram icon\">\r\n                      </a>\r\n                      \r\n                  </td>\r\n                </tr>\r\n              </tbody>\r\n            </table>\r\n            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"600\" style=\"color: #333333;background-color: #eaeaea;text-align: center;margin-bottom: 30px;\">\r\n                <tbody>\r\n                  <tr>\r\n                    <td style=\"color: #a7a7aa;font-size: 14px;line-height: 16px;font-weight: 400;font-family: Arial, Helvetica, sans-serif;margin-bottom: 20px;\">\r\n                      <a href=\"https://miami-chess.ru/ru/cources\" style=\"text-decoration:none;color:#08a9fa;\" target=\"_blank\" rel=\" noopener noreferrer\">Новости</a> |\r\n                      <a href=\"https://chess-good.ru/ru/home/contacts/\" style=\"text-decoration:none;color:#08a9fa;\" target=\"_blank\" rel=\" noopener noreferrer\">Обратная связь</a> |\r\n                      <a href=\"https://miami-chess.ru/ru/home/privacy/\" style=\"text-decoration:none;color:#08a9fa;\" target=\"_blank\" rel=\" noopener noreferrer\">Помощь</a>\r\n                    </td>\r\n                  </tr>\r\n                </tbody>\r\n            </table>\r\n            <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"color: #333333;font-size: 18px;line-height: 21px;max-width: 600px;width: 100%;background-color: #eaeaea;margin: 0 auto;padding:0 50px;padding-bottom: 50px;\">\r\n                <tbody>\r\n                  <tr>\r\n                    <td class=\"h-n_mr_css_attr\" style=\"padding:0 0 20px;font:.8rem/1.5 Calibri, Arial, Helvetica, sans-serif;color:#4f4f4f;\">\r\n                      Это автоматически созданное сообщение. Если у Вас возникли какие-либо вопросы, можете ознакомиться со <a href=\"https://miami-chess.ru/ru/privacy/\" target=\"_blank\" rel=\" noopener noreferrer\">справочной информацией</a> или задать вопрос в <a href=\"https://miami-chess.ru/ru/home/faq/\" target=\"_blank\" rel=\" noopener noreferrer\">системе тикетов</a>\r\n\r\n\r\n                    </td>\r\n                  </tr>\r\n                </tbody>\r\n              </table>\r\n          </td>\r\n        </tr>\r\n      </tbody>\r\n    </table>";
                        Mmessage.To.Add(email);

                        try
                        {
                            smtpClient.Send(Mmessage);
                        }
                        catch (Exception ex)
                        {
                            //Error, could not send the message
                            
                        }
                    }
                }             
            } 
            catch(Exception e) 
            {
                
            }

        }
    }
}