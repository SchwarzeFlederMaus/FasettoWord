using System.Linq.Expressions;

namespace FasettoWordCore
{
    public static class ExpressionHelpers
    {
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)
        {
            return lambda.Compile().Invoke();
        }
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            // Converts a lambda from () => SomeProperty to common SomeProperty
            var expression = lambda.Body as MemberExpression;

            // Get the property information so we can set the value
            var propertyInfo = expression?.Member as System.Reflection.PropertyInfo;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            //Set the value
            propertyInfo?.SetValue(target, value);
        }
    }
}
