namespace DesingPatternSamples.Behavioral.ChainOfResponsibility
{
    public class TwoHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 200 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 200;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred note is dispatched by TwoHundredHandler");
                }
            }
            //Then check the Pending amount
            long pendingAmountToBeProcessed = requestedAmount % 200;
            //If the Pending amount is greater than 0, then call the next handler to handle the request
            if (pendingAmountToBeProcessed > 0)
            {
                //For TwoHundredHandler, the next handler is HundredHandler 
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
