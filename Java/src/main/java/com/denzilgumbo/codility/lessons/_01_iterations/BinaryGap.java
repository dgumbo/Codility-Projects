package com.denzilgumbo.codility.lessons._01_iterations;

public class BinaryGap {
    
    public static void main(String[] args) {
        BinaryGap ps = new BinaryGap();
        
         int A = 592;
        // int A = 5;
        
        System.out.println("BinaryGap : " + ps.solution(A));
    }

    public int solution(int N) {
        // write your code in Java SE 8   
        if (N <= 4) return 0;
         
        String a = Integer.toBinaryString(N) ; 

        int iMaxGap = 0;
        int iCurrentGap = 0;
        int iPrevChar = -1;
        boolean bStartCount = false;
        for (int i = 0; i < a.length(); i++) {            
            int iCurrent =Integer.valueOf(a.substring(i, i+1) );
            
            System.out.println("iCurrentChar : " + iCurrent);
            
            if (iCurrent == 0 && iPrevChar == 1) bStartCount = true;
            
            if (iCurrent == 0 && bStartCount == true)  iCurrentGap ++; 
                        
            if (iCurrent == 1 && iPrevChar == 0) iMaxGap = iCurrentGap > iMaxGap ? iCurrentGap : iMaxGap;
            
            if (iCurrent == 1){ 
                bStartCount = false;
                iCurrentGap = 0;
            } 
            
            iPrevChar =Integer.valueOf(a.substring(i, i+1) );
        }

        return iMaxGap;
    }
}
