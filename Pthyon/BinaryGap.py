# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")
import math

def solution(N):
    # write your code in Python 3.6
    
    # print("this is a debug message")
    
    bin = []
    
    r = N
    while r >= 1 :
        m = r % 2
        r = math.floor( r / 2 )
        
        bin.append(m)
        
    max_gap = 0
    temp_gap = 0
     
    p = 0
    for b in bin :
        if p == 1 and b == 0 :
            temp_gap += 1
        if p == 0 and b == 1 :
            if temp_gap > max_gap :
                max_gap = temp_gap
                
            temp_gap = 0
        
        if temp_gap >= 1 and b == 0 and p == 0 :
            temp_gap += 1
            
        # print ("b is :", b)
        
        p = b
    
        
    # print(N, " binary value is ", bin) 
    # print("max_gap is ", max_gap) 
    
    return max_gap


print(solution(15))
print(solution(21251))
print(solution(2741251))
print(solution(2125651))