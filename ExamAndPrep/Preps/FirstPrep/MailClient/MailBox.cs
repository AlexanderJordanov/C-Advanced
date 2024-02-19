using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }
        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        {
            Mail mailToDelete = Inbox.FirstOrDefault(x => x.Sender == sender);
            if (mailToDelete != null)
            {
                Inbox.Remove(mailToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ArchiveInboxMessages()
        {
            Archive.AddRange(Inbox);
            int movedMessages = Inbox.Count;
            Inbox = new();
            return movedMessages;            
        }
        public string GetLongestMessage()
        {
            Mail longestMail = Inbox.OrderByDescending(m=>m.Body).First();
            return longestMail.ToString();
        }
        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
