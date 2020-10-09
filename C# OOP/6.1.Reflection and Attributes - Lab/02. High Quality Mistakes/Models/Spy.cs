using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        FieldInfo[] publicFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
        MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        StringBuilder sb = new StringBuilder();

        foreach (var field in publicFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (var nonPublicF in nonPublicMethods.Where(x=>x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{nonPublicF.Name} have to be public!");
        }

        foreach (var publicMethod in publicMethods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{publicMethod.Name} have to be private!");
        }
        ;
        return sb.ToString().Trim();
    }

    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
            | BindingFlags.NonPublic | BindingFlags.Public);

        StringBuilder builder = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        builder.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            builder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return builder.ToString().Trim();
    }
}
