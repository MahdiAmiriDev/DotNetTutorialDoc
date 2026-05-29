namespace DesingPatternSamples.Behavioral.ChainOfResponsibility
{
    public class FiveHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            //First Check the Number of 500 Notes To Be Dispatched
            long numberofNotesToBeDispatched = requestedAmount / 500;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
                }
            }
            //Then check the Pending amount
            long pendingAmountToBeProcessed = requestedAmount % 500;
            //If Pending amount is greater than 0, then call the next handler to handle the request
            if (pendingAmountToBeProcessed > 0)
            {
                //For FiveHundredHandler, the next handler is TwoHundredHandler  
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
