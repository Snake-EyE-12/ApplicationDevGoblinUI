using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class MessageDialogue
{
    private string message = "I... I don't... I don't remember what I was saying...?";
    private Response[] responses = new Response[0];
    public MessageDialogue(string message, Response[] responses)
    {
        this.message = message;
        this.responses = responses;
    }
    public string getMessage()
    {
        return message;
    }
    public Response[] getResponses()
    {
        return responses;
    }
    public string[] getResponsesAsStrings()
    {
        if (responses == null) return null;
        string[] textResponses = new string[responses.Count()];
        for(int i = 0; i < textResponses.Count(); i++) {
            textResponses[i] = responses[i].getTextMessage();
        }
        return textResponses;
    }
}
public class Response
{
    private string message = "Interesting.";
    private MessageDialogue nextMessage;
    private bool endDialogue = false;
    public Response(string message, MessageDialogue nextMessage)
    {
        this.message = message;
        this.nextMessage = nextMessage;
    }
    public string getTextMessage()
    {
        return message;
    }
    public MessageDialogue getNextMessage()
    {
        return nextMessage;
    }
}