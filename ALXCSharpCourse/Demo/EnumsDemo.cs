using ALXCSharpCourse.Enums;
using ALXCSharpCourse.Models;

namespace ALXCSharpCourse.Demo
{
    public class EnumsDemo
    {
        public static void Run()
        {
            EmailMessage message = new EmailMessage
                (
                    "jankowal@wp.pl",
                    "mmalino@gmail.com",
                    "Sprzedam opla",
                    MessageStatus.DRAFT
                );

            message.ChangeStatus(MessageStatus.SENT);
            message.ChangeStatus(MessageStatus.DRAFT);
            message.ChangeStatus(MessageStatus.PENDING);
            message.ChangeStatus(MessageStatus.SERVICE_FAULT);
        }
    }
}
