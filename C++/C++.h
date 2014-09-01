// C++.h

#pragma once

using namespace System;

namespace C {

	public ref class cpp
	{
		public: 
			int fibonacciRecursivo(int n)
				{
					if (n<2)
						return n;
					else
						return fibonacciRecursivo(n-1) + fibonacciRecursivo(n-2);
				}

			int fibonacciIterativo(int n)
				{
					int prev = -1;
					int result = 1;
					int sum;
					int i;
					prev = -1;
					result = 1;
					for(i = 0;i <= n;++ i)
						{
							sum = result + prev;
							prev = result;
							result = sum;
						}
					return result;
				}
	};
}
