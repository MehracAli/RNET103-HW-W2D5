using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net;
using System.Net.Mail;
using System.Text;

List<string> users = new List<string>();

users.Add("Mehraj Mammadov");
users.Add("Tajir Mammadov");
users.Add("Vahid Mammadov");
users.Add("Murat Vuranok");
users.Add("Asger Hoca");

Random rnd = new();
int userOrder = rnd.Next(users.Count);

string user = string.Empty;

for (int i = -1; i < userOrder; i++)
{
    user = users[userOrder];
}

string[] userInfo = user.Split(" ");

StringBuilder html = new($"""
    <!DOCTYPE html>
    <html lang = "en">

    <head>
      <meta charset = "UTF-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <title> Document </title>
    </head>

    <body style = "width: 30%; margin: 0 auto;">
      <section class= "w-5">
        <div style = "background: black;">
          <div style = "color: white; text-align: center;">
            <p> Name: {userInfo[0]} </p>
            <p> Surname: {userInfo[1]} </p>
          </div>
        </div>
      </section>
    </body>

    </html>
""");


Console.WriteLine(html);
AlternateView plainView = AlternateView.CreateAlternateViewFromString($"Fullname: {userInfo[0]} {userInfo[1]}", null, "text/plain");
MailMessage mailMessage = new MailMessage(
                                        new MailAddress("mehrajvm@code.edu.az", $"{userInfo[0]} {userInfo[1]}"),
                                        new MailAddress("isim@soyisim.com")
                                        );
mailMessage.Subject = "Tapsiriq mesaji";
mailMessage.Body = html.ToString();
mailMessage.IsBodyHtml = true;

SmtpClient smtpClient = new SmtpClient();
smtpClient.Host = "smtp.gmail.com";
smtpClient.Port = 587;
smtpClient.EnableSsl = true;
smtpClient.UseDefaultCredentials = false;
smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
smtpClient.Credentials = new NetworkCredential("mehrajvm@code.edu.az", "iscxkwonfrjjgegk");
smtpClient.Send(mailMessage);


/*static async Task Execute()
{
    var apiKey = "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";
    var client = new SendGridClient(apiKey);
    var from = new EmailAddress("mehrajvm@code.edu.az", "Mehraj Mammadov");
    var subject = "Sending with SendGrid is Fun";
    var to = new EmailAddress("mehrajalimahmut@gmail.com", "Example User");
    var plainTextContent = "and easy to do anywhere, even with C#";
    var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
    var response = await client.SendEmailAsync(msg);
    Console.WriteLine(response.StatusCode);
    Console.WriteLine(response.Body.ReadAsStringAsync());
}
await Execute();
*/
