using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace MoviesApi.Shared.Utils 
{
    public abstract class FilterHelper<T>
    {
        public static async Task<Func<T, bool>> ConvertStringToPredicate (string filter) 
        {
            var options = ScriptOptions.Default.AddReferences(typeof(T).GetType().Assembly);

            Func<T, bool> filterExpression = await CSharpScript.EvaluateAsync<Func<T, bool>>(filter, options);
            
            return filterExpression;
        }
    }
}