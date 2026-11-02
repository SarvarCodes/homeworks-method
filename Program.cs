using System;
// task.1
/*
ShowWelcome();
static void ShowWelcome()
{
    System.Console.WriteLine("welcome to C# methods!");   
}
*/

/*
task.2
 ShowGreating("Ali");
 ShowGreating("Madina");

 static void ShowGreating(string name)
{
    Console.WriteLine($"Hello, {name}");
}
*/

/*
 task.3
GetPassingScore();
static void GetPassingScore()
{
    Console.WriteLine(60);
}
*/

/*
 task.4
Add(4,7);
static void Add(int first,int second)
{
    Console.WriteLine(first + second);
}
*/
/*
 task.5
CreatOrderMessage("Book",2);
CreatOrderMessage("Pen",5);
static void CreatOrderMessage(string product,int quantity)
{
    Console.WriteLine($"Order: ,{product},{quantity}");
}
*/
/*task.6
int GetTicketPrice(int age, bool isWeekend)
{
    if (age < 0 || age > 120)
    {
        return -1;
    }

    if (age < 7)
    {
        return 0;
    }

    if (isWeekend == false)
    {
        return 10000;
    }
    if (age > 60)
    {
        return 12000;
    }

    return 15000;
}
Console.Write("Enter age: ");

int age = int.Parse(Console.ReadLine()!);
Console.Write("Is weekend (true/false): ");
bool isWeekend = bool.Parse(Console.ReadLine()!);

int price = GetTicketPrice(age, isWeekend);
if (price == -1)
{
    Console.WriteLine("Invalid age");
    return;
}
if (price == 0)
{
    Console.WriteLine("Free");
    return;
}
Console.WriteLine(price + " so'm");*/
/*
task.12 uch xilwaklni overloading qiliw
    Console.WriteLine("Calstring loyihasiga xush keldingiz!!!");
    Console.WriteLine("1.oddiy calculyator.     2.murakkab calculyator");
    Console.WriteLine("1-calkulyatorda -,+,*,/ amallari mavjud");
    Console.WriteLine("2-calculyatorimizda qiyin amallar sonning darajasini topish,ildiz topish amallari mavjud");
    Console.WriteLine("tanlang");

    int bolimtanlash = int.Parse(Console.ReadLine());

    if (bolimtanlash == 1)
    {
        OsonOperatorTanlash();
    }
    else if (bolimtanlash == 2)
    {
        QiyinOperatorTanlash();
    }
    else
    {
        Console.WriteLine("Noto'g'ri tanlov! Faqat 1 yoki 2 ni tanlang.");
    }
}

static void OsonOperatorTanlash()
{
    try
    {
    Console.WriteLine("siz simple calkulationni tanladingiz.");
    Console.WriteLine("inter first number:");
    double a = double.Parse(Console.ReadLine());

    Console.WriteLine("choose one of the operators- -,+,*,/ ");
    char operators = char.Parse(Console.ReadLine());

    Console.WriteLine("inter second number:");
    double b = double.Parse(Console.ReadLine());

    if (operators == '+')
    {
        double result = a + b;
        Console.WriteLine("Result:" + result);
    }
    else if (operators == '-')
    {
        double result1 = a - b;
        Console.WriteLine("Result:" + result1);
    }
    else if (operators == '*')
    {
        if(a < 0 || b < 0)
            {
                throw new Exception("0 qiymat kiritilmasin kupaytirib bulmaydi");
            }
        double result2 = a * b;
        Console.WriteLine("Result:" + result2);
    }
    else if (operators == '/')
    {
        if(a < 0 || b < 0)
            {
                throw new Exception("0 qiymat kiritilmasin bulib bulmaydi");
            }
        if (b == 0)
        {
            Console.WriteLine("Xato: 0 ga bo'lish mumkin emas!");
        }
        else
        {
                try
                {
                    double result3 = a / b;
                    Console.WriteLine("Result:" + result3);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("nolga buliw mumkin emasde");
                }
            double result3 = a / b;
            Console.WriteLine("Result:" + result3);
        }
    }
        else   
        {
            Console.WriteLine("Noto'g'ri operator!");
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


}

static void QiyinOperatorTanlash()
{
    Console.WriteLine("you inter dificult calculation");
    Console.WriteLine("sizga aynan qaysi murakkab amal natijasi kerak tanlang:");
    Console.WriteLine("1.sonni darajasini topish. 2.sonni ildizini topish.");
    try
    {
        int dificultOperator = int.Parse(Console.ReadLine());

    switch (dificultOperator)
    {
        case 1:
            Console.WriteLine("Siz bilan sonning darajasini topamiz.");
            Console.WriteLine("Son kiriting:");
            double dificultNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Darajani kiriting:");
            int daraja = int.Parse(Console.ReadLine());

            double resultDaraja = Math.Pow(dificultNumber, daraja);
            Console.WriteLine($"{dificultNumber} ning {daraja}-darajasi = {resultDaraja}");
            break;

        case 2:
            Console.WriteLine("Siz bilan sonning ildizini topamiz.");
            Console.WriteLine("Ixtiyoriy son kiriting:");
            double dificultNumberIldiz = double.Parse(Console.ReadLine());
                try
                {
                    if(dificultNumberIldiz < 0)
                {
                    throw new Exception("xatolik");
                }
            if (dificultNumberIldiz < 0)
            {
                Console.WriteLine("Manfiy son kiritmang!!!");
            }
            else
            {
                double ildiz = Math.Sqrt(dificultNumberIldiz);
                Console.WriteLine($"{dificultNumberIldiz} ning ildizi = {ildiz:F4}"); // F4 - 4 xona aniqlik
            }        
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("nulga buliw mumkinmasda");
                }
            if(dificultNumberIldiz < 0)
                {
                    throw new Exception("xatolik");
                }
            if (dificultNumberIldiz < 0)
            {
                Console.WriteLine("Manfiy son kiritmang!!!");
            }
            else
            {
                double ildiz = Math.Sqrt(dificultNumberIldiz);
                Console.WriteLine($"{dificultNumberIldiz} ning ildizi = {ildiz:F4}"); // F4 - 4 xona aniqlik
            }
            break;

        default:
            Console.WriteLine("Noto'g'ri tanlov! Faqat 1 yoki 2 ni tanlang.");
            break;
    } 
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
 }
 */
 /*
 task.15.GeometryGuru
         Console.WriteLine("Welcome to Geometryguru project!");
        Console.WriteLine("Siz bu loyihada harxil geometrik shakllarning xisoblashingiz mumkin.");
        Console.WriteLine("Menuda");
        Console.WriteLine("1. Doiraning diametrini aniqlash.");
        Console.WriteLine("2. Kvadratni yuzini hisoblash.");
        Console.WriteLine("3. To`g`ri to`rtburchakning perimetrini hisoblash");
        Console.WriteLine("O`zingizga qiziq bo`lgan geometrik amalni tanlang.");

        int userTanlov = Convert.ToInt32(Console.ReadLine());
        
        switch (userTanlov)
        {
            case 1:
                {
                    Console.WriteLine("Siz bilan doirani diametrini aniqlaymiz!!!");
                    Doira doira = new Doira();
                    doira.HisoblaDiametr();
                }
                break;
            case 2:
                {
                    Console.WriteLine("Siz bilan kvadrat yuzini hisoblaymiz!!!");
                    Kvadrat kvadrat = new Kvadrat();
                    kvadrat.HisoblaYuzi();
                }
                break;
            case 3:
                {
                    Console.WriteLine("To`g`ri to`rtburchakning perimetrini hisoblaymiz!!!");
                    TugriTortburchak tortburchak = new TugriTortburchak();
                    tortburchak.HisoblaPerimetr();
                }
                break;
        }
    }
}

class Doira
{
    public void HisoblaDiametr()
    {
        try
        {
        Console.WriteLine("User radiusni kiriting:");
        Console.Write("Radius =");
        decimal value = Convert.ToDecimal(Console.ReadLine());
        decimal diametr = 2 * value;
        Console.WriteLine("Doiraning diametri: " + diametr);
        }
        catch(Exception ex)
        {
            Console.WriteLine("xatolik" + ex.Message);
        }
        catch (FotmatException)
        {
            Console.WriteLine("faqat son kiritiliwi kerak.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0 kiritmaganing maqul edi!!!");
        }
    }
}

class Kvadrat
{
    public void HisoblaYuzi()
    {
        try
        {
        Console.Write("Kvadratning tomonini kiriting:");
        decimal kvadratTomoni = Convert.ToDecimal(Console.ReadLine());
        decimal resultS = kvadratTomoni * kvadratTomoni;
        Console.WriteLine("Kvadratning yuzasi:" + resultS + "\n");
        }
       catch (FotmatException)
        {
            Console.WriteLine("faqat son kiritiliwi kerak.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0 kiritmaganing maqul edi!!!");
        }
    }
}

class TugriTortburchak
{
    public void HisoblaPerimetr()
    {
        try
        {
            Console.WriteLine("1-chi tomonni kiriting:");
            decimal value1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("2-chi tomonni kiriting:");
            decimal value2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("3-chi tomonni kiriting:");
            decimal value3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("4-chi tomonni kiriting:");
            decimal value4 = Convert.ToDecimal(Console.ReadLine());

            decimal perimetr = value1 + value2 + value3 + value4;

            Console.WriteLine("Natija:" + perimetr);   
        }
        catch(Exception ex)
        {
            Console.WriteLine("muammo" + ex.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0 kiritma");
        }
    }
}
  */
