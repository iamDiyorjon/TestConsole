namespace TestConsole;

public static class GenericMapper
{
    public static TDestination Map<TSource, TDestination>(TSource source)
        where TDestination : new()
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        var destination = new TDestination();

        var sourceType = typeof(TSource);
        var destinationType = typeof(TDestination);

        foreach (var sourceProp in sourceType.GetProperties())
        {
            var destinationProp = destinationType.GetProperty(sourceProp.Name);

            if (destinationProp != null && destinationProp.CanWrite &&
                destinationProp.PropertyType == sourceProp.PropertyType)
            {
                var value = sourceProp.GetValue(source);
                destinationProp.SetValue(destination, value);
            }
        }

        return destination;
    }
}

