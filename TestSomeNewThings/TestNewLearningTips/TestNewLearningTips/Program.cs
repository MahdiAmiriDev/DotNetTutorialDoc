using System.Timers;
using TestNewLearningTips.ImplicitOperator;
using TestNewLearningTips.Indexer;
using TestNewLearningTips.LazySample;



//----------------Implicit Operator Sample


Rial rial = new(2_000_000);

Toman toman = rial;

Console.ReadKey();


//---------------- Class Indexer Sample

IndexerSample indexerSample = new();

indexerSample.Dictionary.Add(1, "one");
indexerSample.Dictionary.Add(2, "two");
indexerSample.Dictionary.Add(3, "three");
indexerSample.Dictionary.Add(4, "four");

var stringIndexer = indexerSample["one"];
Console.WriteLine(stringIndexer);

var intIndexer = indexerSample[3];
Console.WriteLine(intIndexer);

Console.ReadKey();


//---------------- Class Indexer Sample

Lazy<GenerateSampleData> lazySample = new();

Console.WriteLine("is value created: {0}", lazySample.IsValueCreated);

var data = lazySample.Value;

foreach (var item in data.DataList)
{
    Console.WriteLine(item);
}

Console.ReadKey();



//---------------- Aggregate

int[] intArray = { 1, 3, 4, 5, 6, 7, 8, 9, 0, 10 };

var sum = intArray.Aggregate((acc, item) => acc + item);

Console.WriteLine(sum);

var max = intArray.Aggregate((acc, item) => acc > item ? acc : item);

Console.WriteLine(max);

var average = intArray.Aggregate((acc, item) => acc + item) / (double)intArray.Count();

Console.WriteLine(average);

Console.ReadKey();


//---------------- Timer

var timer = new System.Timers.Timer(TimeSpan.FromSeconds(1));

timer.Elapsed += PrintDateTime;

timer.Start();

void PrintDateTime(object sender, ElapsedEventArgs e)
{
    Console.WriteLine("hour:{0} \n minutes:{1}", DateTime.Now.Hour, DateTime.Now.Minute);
}

Console.ReadKey();