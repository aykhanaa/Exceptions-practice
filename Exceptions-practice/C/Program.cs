

using Exceptions_practice.Helpers.Exceptions;

void Calculate()
{
    bool isCorrectCalculate = true;
    try
    {
        bool isCorrect;

        int a = 5;
        int b = 0;
        //var result = a / b;
        //Console.WriteLine(result);

        if (b == 0)
        {
            return;
        }

        int[] arr = { 1, 2, 3 };

        //arr[5] = 100;

    }
    catch (Exception ex)
    {
        isCorrectCalculate = false;
    }
    finally
    {
        SendMessage(isCorrectCalculate);
    }
}

//Calculate();
void SendMessage(bool isCorrectCode)
{
    if (isCorrectCode)
    {
        Console.WriteLine("Your message successfully");
    }
    else
    {
        Console.WriteLine("Your message failed");
    }
}

string GetById(int?id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException(nameof(id),"Salam,menem exception");
            throw new CustomArgumentNullException("Argument cannot be null");
        }
        //ArgumentNullException.ThrowIfNull(id);


        return "Kamran bey";
    }
    catch (Exception ex)
    {
        return ex.Message;
    }
   
}

var result = GetById(null);

Console.WriteLine(result);