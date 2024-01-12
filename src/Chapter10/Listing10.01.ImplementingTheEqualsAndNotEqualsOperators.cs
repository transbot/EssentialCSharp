namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_01;

#region INCLUDE
public sealed class ProductSerialNumber
{
    #region EXCLUDE
    public ProductSerialNumber(
        string productSeries, int model, long id)
    {
        ProductSeries = productSeries;
        Model = model;
        Id = id;
    }

    public string ProductSeries { get; }
    public int Model { get; }
    public long Id { get; }


    public override int GetHashCode()
    {
        int hashCode = ProductSeries.GetHashCode();
        hashCode ^= Model;  // XOR (异或)
        hashCode ^= Id.GetHashCode();  // XOR (异或)
        return hashCode;
    }

    public override bool Equals(object? obj)
    {
        if(obj is null)
        {
            return false;
        }
        if(ReferenceEquals(this, obj))
        {
            return true;
        }
        if(this.GetType() != obj.GetType())
        {
            return false;
        }
        return Equals((ProductSerialNumber)obj);
    }

    public bool Equals(ProductSerialNumber? obj)
    {
        // STEP 3: Possibly check for equivalent hash codes
        // if (this.GetHashCode() != obj.GetHashCode())
        // {
        //    return false;
        // } 

        // STEP 4: Check base.Equals if base overrides Equals()
        // System.Diagnostics.Debug.Assert(
        //     base.GetType() != typeof(object));
        // if ( base.Equals(obj) )
        // {
        //    return false;
        // } 

        // STEP 1: Check for null
        return ((obj is not null)
            // STEP 5: Compare identifying fields for equality.
            && (ProductSeries == obj.ProductSeries) &&
            (Model == obj.Model) &&
            (Id == obj.Id));
    }
    #endregion EXCLUDE

    public static bool operator ==(
        ProductSerialNumber leftHandSide,
        ProductSerialNumber rightHandSide)
    {

        // 检查leftHandSide是否为null，
        // (否则operator == 会递归调用)
        if(leftHandSide is null)
        {
            // 如果rightHandSide也为null，就返回true；
            // 否则返回false
            return rightHandSide is null;
        }

        return (leftHandSide.Equals(rightHandSide));
    }

    public static bool operator !=(
        ProductSerialNumber leftHandSide,
        ProductSerialNumber rightHandSide)
    {
        return !(leftHandSide == rightHandSide);
    }
}
#endregion INCLUDE
