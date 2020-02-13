# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(A):
    # write your code in Python 3.6
    if len(A) == 0 :
        return 1
        
    B = sorted(A)
    
    if B[0] != 1 :
        return 1
    
    x = 0
    while x <= len(B) - 1 - 1 :
        #print ("B[x] + 1 =",  B[x] + 1 , ". B [x+1] =",  B [x+1])
        #print ("B[x]  =",  B[x]   , ". B [x+1] =",  B [x+1])
        if ( B[x] + 1 ) != B[x+1] :
            #print (" now returning ", B[x] + 1 )
            return B[x] + 1
            
        x += 1
    
    return B[ len(B) - 1 ] + 1
