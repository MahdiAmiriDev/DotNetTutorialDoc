namespace Calculator.Test.Unit.ClassFixture;


//shared fixture
//هر جیزی که بخواهیم را می توانیم در اینجا بگذاریم
//این کلاس می تواند به عنوان 
//parent
//در نظر گرفته شود و در کلاس تست خود از آن استفاده کنیم

//در این حالت فقط یک بار ctor
//اجرا می شود در ازای کل تست های کلاسی که از آن استفاده کرده است
public class ComputingClassFixture : IDisposable
{
    public readonly Computing _computing;
    public ComputingClassFixture()
    {
        _computing = new Computing();
    }

    //برای thearDown
    //استفاده می شود
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}