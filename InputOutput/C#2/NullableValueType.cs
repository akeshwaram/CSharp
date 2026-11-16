namespace InputOutput.C_2;
internal class NullableValueType
{
	//both these define nullable int
	int? a; //instance nullable typedefaults to null
	Nullable<int> b = null;

	public int? Example() {
		
		//local nullable type variable needs to be initialized
		int? val = 0;
		return val;
	}
}
