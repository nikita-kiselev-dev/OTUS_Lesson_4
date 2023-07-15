using System.IO;
using TMPro;
using UnityEngine;

public class DataTypeConversion : MonoBehaviour
{
    private byte byteType = 255;
    private sbyte sByteType = 127;
    private short shortType = 32767;
    private ushort uShortType = 65535;
    private int intType = 2147483647;
    private uint uIntType = 4294967295;
    private long longType = 9223372036854775807;

    private float floatType = 0.5f;
    private double doubleType = 1.0d;
    private decimal decimalType = 1.5m;

    private byte example1;
    private int example2;
    private float example3;
    private double example4;
    private float example5;
    private int example6;
    private string example7;

    private string stringResult;

    private string saveFileName = "StringResult.txt";

    public TextMeshProUGUI DebugText;

    public void ConvertNumbers()
    {
        //Сужающее явное преобразование целые числа
        example1 = (byte)shortType;
        Debug.Log($"{shortType} short to byte converted: {example1}");
        
        //Расширяещее неявное преобразование целые числа
        example2 = byteType;
        Debug.Log($"{byteType} byte to int converted: {example2}");
        
        //Сужающее явное преобразование вещественные числа
        example3 = (float)doubleType;
        Debug.Log($"{doubleType} double to float converted: {example3}");
        
        //Расширяющее неявное преобразование вещественные числа
        example4 = floatType;
        Debug.Log($"{floatType} float to double converted: {example4}");
        
        //Неявное преобразование целого в вещественное
        example5 = intType;
        Debug.Log($"{intType} int to float converted: {example5}");
        
        //Явное преобразование вещественного в целое
        example6 = (int)decimalType;
        Debug.Log($"{decimalType} decimal to int converted: {example6}");
        
        //Преборазование целого числа в текст
        example7 = intType.ToString();
        Debug.Log($"{intType} decimal to string converted: {example7}");

        DebugText.text = "Numbers converted!";

    }

    public void ConvertToString()
    {
        stringResult =
            $"{shortType}:{example1};{byteType}:{example2};{doubleType}:{example3};{floatType}:{example4};{intType}:{example5};" +
            $"{decimalType}:{example6};{intType}:{example7}";
        Debug.Log(stringResult);

        DebugText.text = "Numbers converted to string!";
    }

    public void SaveFile()
    {
        string saveFilePath = Application.persistentDataPath + "/" + saveFileName;
        
        File.WriteAllText(saveFilePath, stringResult);
        
        Debug.Log($"Your file saved here: {saveFilePath}");

        DebugText.text = "File saved!";
    }    
}
