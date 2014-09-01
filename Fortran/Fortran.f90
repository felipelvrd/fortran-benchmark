
    recursive function fibonacci(n) result (fib_result)
        integer  :: n, fib_result
        if (n <= 2) then
	        fib_result = 1
        else
	        fib_result = fibonacci(n-1) + fibonacci(n-2)
        endif
    end FUNCTION  
    
    
    FUNCTION FIBOREC(A)

           !DEC$ ATTRIBUTES DLLEXPORT :: FIBOREC

            INTEGER :: A, FIBOREC
            
            INTEGER fibonacci
            
            FIBOREC = fibonacci(A)
            
    END FUNCTION
    
    FUNCTION FIBITE(A)

           !DEC$ ATTRIBUTES DLLEXPORT :: FIBITE

            INTEGER :: A

            INTEGER :: FIBITE
            
            integer prev, sum,i
            prev=-1
	        FIBITE = 1;
            i=0;
            do while(i<=A)
                sum = FIBITE + prev;
		        prev = FIBITE;
	        	FIBITE = sum;
                i=i+1;
            end do
            
    END FUNCTION
    
         