using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using MoviesApi.Movies.Domain;
using System.Linq.Expressions;

namespace MoviesApi.Shared.Utils 
{
    public class MovieFilterHelper
    {
        public static async Task<Func<Movie, bool>> ConvertStringToPredicate (string filter) 
        {
            var options = ScriptOptions.Default.AddReferences(typeof(Movie).Assembly);

            Func<Movie, bool> filterExpression = await CSharpScript.EvaluateAsync<Func<Movie, bool>>(filter, options);
            return filterExpression;
        }
    }
}