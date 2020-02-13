# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(A, K):
    # write your code in Python 3.6
    if len(A) == 0 or len(A) == 1 :
        return A
    
    k = K % len( A )
    
    if k == 0  :
        return A
    
    # print( "Count is", len(A) , "k is ", k)
    
    B = []
    p = 0
    x = 0
    while x < len( A ) :
        if ( x - k ) >= 0 :
            p = x - k 
        else :
            p = len( A ) -  k + x
        
        # print ( p )
        B.append( A[p] )
        # B.append( p )
        x += 1
    
    return B