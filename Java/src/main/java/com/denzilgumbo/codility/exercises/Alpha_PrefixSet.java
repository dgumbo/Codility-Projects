package com.denzilgumbo.codility.exercises;

import java.util.ArrayList;
import java.util.Base64;
import java.util.List;

public class Alpha_PrefixSet {
    
    public static void main(String[] args) {
        Alpha_PrefixSet ps = new Alpha_PrefixSet();
        
        //int[] A = new int[]{1,1,1,2,5,7,5,6,0};
        //int[] A = new int[]{2,2,1,0,1};
        //int[] A = new int[]{88,66};
        //int[] A = new int[]{99};
        //int[] A = new int[]{2,1};
        //int[] A = new int[]{0,1};
        //int[] A = new int[]{19, 6, 19, 6, 19, 6, 19, 6, 19, 6, 19, 6};
         int[] A = new int[]{73, 7, 4, 7, 2, 6, 7, 2, 7, 73, 9, 17, 7, 7};
        
        System.out.println(": " + ps.solution(A));
        
        System.out.println("base64 kinah : " + Base64.getEncoder().encodeToString("kinah".getBytes()));
    }

    public int solution(int[] A) {
        // write your code in Java SE 8  
        int z = 0;
        List<Integer> list = new ArrayList<>();

        for (int i = 0; i < A.length; i++) {            
            int x = A[i];
            
            if (!(list.contains(x))){
                list.add(x);
                z = i; 
            }
        }

        return z;
    }
}
