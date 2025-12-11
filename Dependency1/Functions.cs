namespace Dependency1;

using System.Text.Json;
using ExcelDna.Integration;
using ExcelDna.Registration;

public enum SomeEnum
{
    Value1,
    Value2,
}

public record DepClass1
{
    public SomeEnum EnumProperty { get; init; }
    public string? StringProperty { get; init; }
    public string? StringProperty1 { get; init; }
    public string? StringProperty2 { get; init; }
    public string? StringProperty3 { get; init; }
    public string? StringProperty4 { get; init; }
    public string? StringProperty5 { get; init; }
    public string? StringProperty6 { get; init; }
    public string? StringProperty7 { get; init; }
    public string? StringProperty8 { get; init; }
    public string? StringProperty9 { get; init; }
    public string? StringProperty10 { get; init; }
    public string? StringProperty11 { get; init; }
    public string? StringProperty12 { get; init; }
    public string? StringProperty13 { get; init; }
    public string? StringProperty14 { get; init; }
    public string? StringProperty15 { get; init; }
    public string? StringProperty16 { get; init; }
    public string? StringProperty17 { get; init; }
    public string? StringProperty18 { get; init; }
}

public class DepClass2
{
    [ExcelAsyncFunction]
    public static async Task<string> SomeFuncWorks(
        [ExcelArgument] string s,
        [ExcelArgument] string s1,
        [ExcelArgument] string s2,
        [ExcelArgument] string s3,
        [ExcelArgument] string s4,
        [ExcelArgument] string s5,
        [ExcelArgument] string s6,
        [ExcelArgument] string s7,
        [ExcelArgument] string s8,
        [ExcelArgument] string s9,
        [ExcelArgument] string s10,
        [ExcelArgument] string s12,
        [ExcelArgument] SomeEnum EnumProperty,
        [ExcelArgument] string s17,
        [ExcelArgument] string s18
    )
    {
        var myModel = new DepClass1
        {
            EnumProperty = EnumProperty,
            StringProperty = s,
            StringProperty1 = s1,
            StringProperty2 = s2,
            StringProperty3 = s3,
            StringProperty4 = s4,
            StringProperty5 = s5,
            StringProperty6 = s6,
            StringProperty7 = s7,
            StringProperty8 = s8,
            StringProperty9 = s9,
            StringProperty10 = s10,
            StringProperty12 = s12,
            StringProperty17 = s17,
            StringProperty18 = s18,
        };
        var doSomeRequestWithModel = await Task.FromResult(JsonSerializer.Serialize(myModel));
        return doSomeRequestWithModel;
    }

    [ExcelAsyncFunction]
    public static async Task<string> SomeFuncBroken(
        [ExcelArgument] string s,
        [ExcelArgument] string s1,
        [ExcelArgument] string s2,
        [ExcelArgument] string s3,
        [ExcelArgument] string s4,
        [ExcelArgument] string s5,
        [ExcelArgument] string s6,
        [ExcelArgument] string s7,
        [ExcelArgument] string s8,
        [ExcelArgument] string s9,
        [ExcelArgument] string s10,
        [ExcelArgument] string s11,
        [ExcelArgument] string s12,
        [ExcelArgument] string s13,
        [ExcelArgument] string s14,
        [ExcelArgument] string s15,
        [ExcelArgument] string s16,
        [ExcelArgument] SomeEnum EnumProperty,
        [ExcelArgument] string s17,
        [ExcelArgument] string s18
    )
    {
        var myModel = new DepClass1
        {
            EnumProperty = EnumProperty,
            StringProperty = s,
            StringProperty1 = s1,
            StringProperty2 = s2,
            StringProperty3 = s3,
            StringProperty4 = s4,
            StringProperty5 = s5,
            StringProperty6 = s6,
            StringProperty7 = s7,
            StringProperty8 = s8,
            StringProperty9 = s9,
            StringProperty10 = s10,
            StringProperty11 = s11,
            StringProperty12 = s12,
            StringProperty13 = s13,
            StringProperty14 = s14,
            StringProperty15 = s15,
            StringProperty16 = s16,
            StringProperty17 = s17,
            StringProperty18 = s18,
        };
        var doSomeRequestWithModel = await Task.FromResult(JsonSerializer.Serialize(myModel));
        return doSomeRequestWithModel;
    }
}
