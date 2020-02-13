# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(A):
    # write your code in Python 3.6
    
    if len(A) == 1 :
        return A[0]
        
    A = sorted(A) 
    
    x = 0
    while x < len(A) - 1 :
        if A[x] != A[x+1] :
            return A[x]
            
        x += 2
    
    return A[len(A) - 1]



# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution2(A):
    # write your code in Python 3.6
    
    if len(A) == 1 :
        return A[0]
    
    B = []
    for a in A :
        # x = 99999999
        if a in B :
            B.pop( B.index(a) )
        else :
            B.append( a )
        
        # print ( B )
        
    
    return B[0]

