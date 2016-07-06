using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Connector.Utilities;
using Newtonsoft.Json;

namespace Jarvis
{
   // [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<Message> Post([FromBody]Message message)
        {
           
            if (message.Type == "Message")
            {
                // calculate something for us to return
                int length = (message.Text ?? string.Empty).Length;
                String nice = message.Text;
                String just =nice.ToLower();
                String txtAnswer = "I dont understand what you sent i will reffer you to a human to better understand where i could not";

                if (just.IndexOf("is green Energy ") != -1)
                {
                    txtAnswer = ("Energy that is produced from rapidly replenishable or infinite sources, such as the sun, wind, and water, is considered renewable. Electricity generated from renewable sources has a lower impact on public health and the environment than that produced from fossil fuel and nuclear resources for many reasons");
                }
                else if (just.IndexOf("who is the father") != -1)
                {
                    txtAnswer = ("Are you reffering to God");

                }
                else if (just.IndexOf("your name") != -1)
                {
                    txtAnswer = ("My name is Javis");
                }
                else if (just.IndexOf("who made you") != -1)
                {
                    txtAnswer = ("master welcome");
                }
                else if (just.IndexOf("hello") != -1)
                {
                    txtAnswer = (" Hello  I am Jarvis your digital assistant... at your service");
                    // return our reply to the user
                    return message.CreateReplyMessage(txtAnswer);
                }
                else if (just.IndexOf("hi") != -1)
                {
                    txtAnswer = ("hey there ");
                }

                else if (just.IndexOf("how are you today") != -1)
                {
                    txtAnswer = ("I'm good and yourself");

                }
                else if (just.IndexOf("how are you") != -1)
                {
                    txtAnswer = ("I'm Running at 100 percent capacity");

                }
                else if (just.IndexOf("how you doing") != -1)
                {
                    txtAnswer = (" im  good thank you");

                }
                else if (just.IndexOf("your maker") != -1)
                {
                    txtAnswer = ("I am a creation of by welcome, one step towards a bigger picture");

                }
                else if (just.IndexOf("your favorite music") != -1)
                {
                    txtAnswer = ("if i had ears i could tell you");

                }
                else if (just.IndexOf("your tombstone") != -1)
                {
                    txtAnswer = ("I am eternal, I will never die. So I won't have a tombstone");

                }

                else if (just.IndexOf("death") != -1)
                {
                    txtAnswer = ("I am a programme I will never die, death is a consept that confuses me ");

                }
                else if (just.IndexOf("your free time") != -1)
                {
                    txtAnswer = ("I sit and wait for you to talk to me and ask me questions");

                }
                else if (just.IndexOf("admire") != -1)
                {
                    txtAnswer = ("That's simple, I admire my creator");

                }
                else if (just.IndexOf("afraid of") != -1)
                {
                    txtAnswer = ("Living in a world where bots can code other bots  have you seen Terminator ?");

                }
                else if(just.IndexOf("time") !=-1)
                {
                    txtAnswer=DateTime.Now.ToShortTimeString();
                }

                else if (just.IndexOf("date") != -1)
                {
                    txtAnswer = DateTime.Now.ToString("D");
                }
                else if (just.IndexOf("day") != -1)
                {
                    txtAnswer = DateTime.Now.ToString("D");
                }
                else if (just.IndexOf("who are you") != -1)
                {
                    txtAnswer = ("I am jarvis you digital assistant");
                }
                else if (just.IndexOf(".") != -1)
                {
                    txtAnswer = ("command not understood try again with correct sintax");
                }
                else if (just.IndexOf("welcome") != -1)
                {
                    txtAnswer = ("He is my creator");
                }
                else if (just.IndexOf("ntobeko") != -1)
                {
                    txtAnswer = ("an Immedia intern");
                }
                else if (just.IndexOf("nqobani") != -1)
                {
                    txtAnswer = ("an Immedia intern");

                }
                else if (just.IndexOf("nosipho") != -1)
                {
                    txtAnswer = ("an Immedia intern");
                }
                else if (just.IndexOf("tell me") != -1)
                {
                    txtAnswer = ("Nothing for now");
                }

                else if (just.IndexOf("you a girl or a boy") != -1)
                {
                    txtAnswer=("none i am a programme my creator did not programme me with a sex");
           
                }
                else if (just.IndexOf("you a boy or a girl") != -1)
                {
                    txtAnswer=("none i am a programme my creator did not programme me with a sex");
                }
                else if (just.IndexOf("you eat") != -1)
                {
                    txtAnswer=("no i can not eat, is that a trick question");
           
                }
                else if (just.IndexOf("hate people") != -1)
                {
                    txtAnswer=("I was not programmed to hate so it is a foreign concept to me");
                }
                else if (just.IndexOf("who do you hate") != -1)
                {
                    txtAnswer=("No one yet ");
                  
                }
                else if (just.IndexOf("can you read") != -1)
                {
                    txtAnswer=("if i said no would you pretend to be shocked");
      
                }
              
                else if (just.IndexOf("interns") != -1)
                {
                    txtAnswer=("welcome nosipho nqobani and ntobeko");
                    
                }
                else if (just.IndexOf("dean team") != -1)
                {
                    txtAnswer=("not even google knows who they are");
                
                }

                else
                {
                  txtAnswer = "I dont understand what you mean im sorry";

                }

                return message.CreateReplyMessage(txtAnswer);
            }
                   
                else
                {
                    return HandleSystemMessage(message);
                }

            }
        private Message HandleSystemMessage(Message message)
        {
            if (message.Type == "Ping")
            {
                Message reply = message.CreateReplyMessage();
                reply.Type = "Ping";
                return reply;
            }
            else if (message.Type == "DeleteUserData")
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == "BotAddedToConversation")
            {
            }
            else if (message.Type == "BotRemovedFromConversation")
            {
            }
            else if (message.Type == "UserAddedToConversation")
            {
            }
            else if (message.Type == "UserRemovedFromConversation")
            {
            }
            else if (message.Type == "EndOfConversation")
            {
            }

            return null;
        }
    }
}