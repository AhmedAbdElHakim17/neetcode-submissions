public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i = 0; i < 9; i++)
        {
            HashSet<char> set = new HashSet<char>();
            for(int j = 0; j < 9; j++)
            {
                if(board[i][j] == '.') 
                    continue;
                if(!set.Add(board[i][j]))  
                    return false;            
            }
        }

        for(int i = 0; i < 9; i++)
        {
            HashSet<char> set = new HashSet<char>();
            for(int j = 0; j < 9; j++)
            {
                if(board[j][i] == '.') 
                    continue;
                if(!set.Add(board[j][i]))  
                    return false;            
            }
        }

        for(int k = 0; k < 9; k++)
        {
            HashSet<char> set = new HashSet<char>(9);
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int row = (k / 3) * 3 + i;
                    int col = (k % 3) * 3 + j;
                    if(board[row][col] == '.') 
                        continue;
                    if(!set.Add(board[row][col]))  
                        return false;            
                }
            }
        }
        return true;
    }
}
