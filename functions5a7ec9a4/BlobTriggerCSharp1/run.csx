public static void Run(Stream myBlob, string name, TraceWriter log)
{
    // very smart comment
    log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");    
}
