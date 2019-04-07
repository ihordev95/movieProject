namespace Team3_Project.Databases {
	public class superclass {
		private delegate superclass[] assortment(System.Collections.Generic.List<superclass> list);
		private static type[] resolution<type>(System.Converter<superclass , type> conversion , constructor constructor , subroutine subroutine , System.Object[] initialize , assortment assortment) {
			System.Collections.Generic.List<superclass> list = subroutine.Invoke(constructor , initialize);
			superclass[] array = assortment.Invoke(list);
			return System.Array.ConvertAll(array , conversion);
		}
		protected static type[] collection<type>(System.Converter<superclass , type> conversion , constructor constructor , subroutine subroutine , System.Object[] initialize) {
			superclass[] subprogram(System.Collections.Generic.List<superclass> list) {
				return list.ToArray();
			}
			return resolution(conversion , constructor , subroutine , initialize , subprogram);
		}
		protected static type individual<type>(System.Converter<superclass , type> conversion , constructor constructor , subroutine subroutine , System.Object[] initialize) {
			superclass[] subprogram(System.Collections.Generic.List<superclass> list) {
				return list.Count > 0 ? list.ToArray() : new superclass[] { constructor.Invoke() };
			}
			return resolution(conversion , constructor , subroutine , initialize , subprogram)[0];
		}
		public delegate superclass constructor();
		public delegate System.Collections.Generic.List<superclass> subroutine(constructor constructor , System.Object[] initialise);
	}
}