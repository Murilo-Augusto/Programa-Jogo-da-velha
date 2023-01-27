using System;
class Program 
{
	static void MostrarJogo(string[,] jogoDaVeia)
	{
		Console.ForegroundColor = ConsoleColor.DarkMagenta;
		Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t      |     |      ");
    	for(int i = 0; i < 3; i++)
		{
			for(int j = 0; j < 3; j++)
			{
				if(j<2)
				{	
					if(jogoDaVeia[i, j] == "X"){
						if(j == 0)
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;		
							Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;	
							Console.Write("|");
						}
						else{
							Console.ForegroundColor = ConsoleColor.DarkRed;		
							Console.Write("  {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;	
							Console.Write("|");
						}
					}
					else if(jogoDaVeia[i, j] == "@"){
						if(j == 0)
						{
							Console.ForegroundColor = ConsoleColor.DarkBlue;		
							Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;	
							Console.Write("|");
						}
						else 
						{
							Console.ForegroundColor = ConsoleColor.DarkBlue;		
							Console.Write("  {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;	
							Console.Write("|");
						}
					}				
					else{
						if(j == 0)
						{
							Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;
							Console.Write("|");
						}
						else
						{
							Console.Write("  {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;	
							Console.Write("|");
						}
					}
				}
				else
				{
					if(jogoDaVeia[i, j] == "X")
					{	
						Console.ForegroundColor = ConsoleColor.DarkRed;	
						Console.Write("  {0}  ",jogoDaVeia[i, j]);
						Console.ForegroundColor = ConsoleColor.DarkMagenta;	
					}
					else if(jogoDaVeia[i, j] == "@")
					{
						Console.ForegroundColor = ConsoleColor.DarkBlue;	
						Console.Write("  {0}  ",jogoDaVeia[i, j]);
						Console.ForegroundColor = ConsoleColor.DarkMagenta;	
					}
					else
					{
						if(j == 0)
						{
							Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t  {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;
						}
						else
						{
							Console.Write("  {0}  ",jogoDaVeia[i, j]);
							Console.ForegroundColor = ConsoleColor.DarkMagenta;	
						}
					}
				}
			}
			if(i<2)
			{
				Console.Write("\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t _____|_____|_____\n");
				Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t      |     |      ");
			}
			else if(i==2)
		    	Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t      |     |      ");
		}
		Console.WriteLine();
	}
	static int Jogador(string position, string[,] jogoDaVeia, string bolaOuX)
	{
		int value = 0;
		if(bolaOuX.ToUpper() == "X")
		{
			if(position == "1")
			{
				if(jogoDaVeia[0,0] != "X" && jogoDaVeia[0,0] != "@")
					jogoDaVeia[0,0] = "X";
				else
					return(1);
			}
			else if(position == "2")
			{
				if(jogoDaVeia[0,1] != "X" && jogoDaVeia[0,1] != "@")
					jogoDaVeia[0,1] = "X";
				else
					return(1);
			}
			else if(position == "3")
			{
				if(jogoDaVeia[0,2] != "X" && jogoDaVeia[0,2] != "@")
					jogoDaVeia[0,2] = "X";
				else
					return(1);
			}
			else if(position == "4")
			{
				if(jogoDaVeia[1,0] != "X" && jogoDaVeia[1,0] != "@")
					jogoDaVeia[1,0] = "X";
				else
					return(1);
			}
			else if(position == "5")
			{
				if(jogoDaVeia[1,1] != "X" && jogoDaVeia[1,1] != "@")
					jogoDaVeia[1,1] = "X";
				else
					return(1);

			}
			else if(position == "6")
			{
				if(jogoDaVeia[1,2] != "X" && jogoDaVeia[1,2] != "@")
					jogoDaVeia[1,2] = "X";
				else
					return(1);
			}
			else if(position == "7")
			{
				if(jogoDaVeia[2,0] != "X" && jogoDaVeia[2,0] != "@")
					jogoDaVeia[2,0] = "X";
				else
					return(1);
			}
			else if(position == "8")
			{
				if(jogoDaVeia[2,1] != "X" && jogoDaVeia[2,1] != "@")
					jogoDaVeia[2,1] = "X";
				else
					return(1);
			}
			else if(position == "9")
			{
				if(jogoDaVeia[2,2] != "X" && jogoDaVeia[2,2] != "@")
					jogoDaVeia[2,2] = "X";
				else
					return(1);
			}
		}
		else if(bolaOuX == "@")
		{
			if(position == "1")
			{
				if(jogoDaVeia[0,0] != "X" && jogoDaVeia[0,0] != "@")
					jogoDaVeia[0,0] = "@";
				else
					return(1);
			}
			else if(position == "2")
			{
				if(jogoDaVeia[0,1] != "X" && jogoDaVeia[0,1] != "@")
					jogoDaVeia[0,1] = "@";
				else
					return(1);
			}
			else if(position == "3")
			{
				if(jogoDaVeia[0,2] != "X" && jogoDaVeia[0,2] != "@")
					jogoDaVeia[0,2] = "@";
				else
					return(1);
			}
			else if(position == "4")
			{
				if(jogoDaVeia[1,0] != "X" && jogoDaVeia[1,0] != "@")
					jogoDaVeia[1,0] = "@";
				else
					return(1);
			}
			else if(position == "5")
			{
				if(jogoDaVeia[1,1] != "X" && jogoDaVeia[1,1] != "@")
					jogoDaVeia[1,1] = "@";
				else
					return(1);
			}
			else if(position == "6")
			{
				if(jogoDaVeia[1,2] != "X" && jogoDaVeia[1,2] != "@")
					jogoDaVeia[1,2] = "@";
				else
					return(1);
			}
			else if(position == "7")
			{
				if(jogoDaVeia[2,0] != "X" && jogoDaVeia[2,0] != "@")
					jogoDaVeia[2,0] = "@";
				else
					return(1);
			}
			else if(position == "8")
			{
				if(jogoDaVeia[2,1] != "X" && jogoDaVeia[2,1] != "@")
					jogoDaVeia[2,1] = "@";
				else
					return(1);
			}
			else if(position == "9")
			{
				if(jogoDaVeia[2,2] != "X" && jogoDaVeia[2,2] != "@")
					jogoDaVeia[2,2] = "@";
				else
					return(1);
			}
		}
		return(value);
	}
	static int VerificaVitoria(string[,] jogoDaVeia)
	{
		#region Condição vencedora horizontal
		// // Condição de vitória para a primeira linha   
		if(jogoDaVeia[0,0] == jogoDaVeia [0,1] && jogoDaVeia[0,1] == jogoDaVeia [0,2])
		{
			return 1;
		}
		// Condição de vitória para a segunda linha
		else if(jogoDaVeia[1,0] == jogoDaVeia [1,1] && jogoDaVeia[1,1] == jogoDaVeia [1,2])
		{
			return 1;
		}
		// Condição de vitória para a terceira linha 
		else if(jogoDaVeia[2,0] == jogoDaVeia [2,1] && jogoDaVeia[2,1] == jogoDaVeia [2,2])
		{
			return 1;
		}
		#endregion

		#region Condição vencedora vertical
		// Condição de vitória para a primeira coluna      
		else if(jogoDaVeia[0,0] == jogoDaVeia [1,0] && jogoDaVeia[1,0] == jogoDaVeia [2,0])
		{
			return 1;
		}
		// Condição de vitória para a segunda coluna
		else if(jogoDaVeia[0,1] == jogoDaVeia [1,1] && jogoDaVeia[1,1] == jogoDaVeia [2,1])
		{
			return 1;
		}
		// Condição de vitória para a terceira coluna
		else if(jogoDaVeia[0,2] == jogoDaVeia [1,2] && jogoDaVeia[1,2] == jogoDaVeia [2,2])
		{
			return 1;
		}
		#endregion


		#region Diagonal Winning Condition
		// Condição para a primeira diagonal 
		else if(jogoDaVeia[0,0] == jogoDaVeia [1,1] && jogoDaVeia[1,1] == jogoDaVeia [2,2])
		{
			return 1;
		}
		// Condição para a segunda diagonal 
		else if(jogoDaVeia[0,2] == jogoDaVeia [1,1] && jogoDaVeia[1,1] == jogoDaVeia [2,0])
		{
			return 1;
		}
		#endregion

		#region Verificando Empate
		// Se todas as células ou valores forem preenchidos com X ou O, então qualquer jogador venceu a partida
		else if (jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] != "9")
		{
			return -1;
		}
		#endregion
		else
		{
			return 0;
		}
	}
	static void Condiçoes(string[,] jogoDaVeia, string bolaOuX)
	{
		if(bolaOuX == "@")
		{
			// Condição para a primeira linha  
			if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X" || jogoDaVeia[0,1] == "X" && jogoDaVeia [0,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia [0,2] == "X")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [0,2] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,2] == "X")
					jogoDaVeia[0,1] = "X";
			}
			// Condição para a segunda linha   
			else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X" || jogoDaVeia[1,1] == "X" && jogoDaVeia [1,2] == "X" || jogoDaVeia[1,0] == "X" && jogoDaVeia [1,2] == "X")
			{
				if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[1,2] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[1,0] = "X";
				else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[1,1] = "X";
			}
			// Condição para a terceira linha   
			else if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X" || jogoDaVeia[2,1] == "X" && jogoDaVeia [2,2] == "X" || jogoDaVeia[2,0] == "X" && jogoDaVeia [2,2] == "X")
			{
				if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,1] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[2,1] = "X";
			}
			// Condição para a primeira coluna       
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X" || jogoDaVeia[1,0] == "X" && jogoDaVeia [2,0] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia [2,0] == "X")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[1,0] = "X";
			}
			// Condição para a segunda coluna  
			else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X" || jogoDaVeia[1,1] == "X" && jogoDaVeia [2,1] == "X" || jogoDaVeia[0,1] == "X" && jogoDaVeia [2,1] == "X")
			{
				if(jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,1] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[0,1] = "X";
				else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[1,1] = "X";
			}
			// Condição para a terceira coluna  
			else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X" || jogoDaVeia[1,2] == "X" && jogoDaVeia [2,2] == "X" || jogoDaVeia[0,2] == "X" && jogoDaVeia [2,2] == "X")
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[1,2] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[1,2] = "X";
			}
			// Condição para a primeira diagonal       
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X" || jogoDaVeia[1,1] == "X" && jogoDaVeia [2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia [2,2] == "X")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[1,1] = "X";
			}
			// Condição para a segunda diagonal  
			else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X" || jogoDaVeia[1,1] == "X" && jogoDaVeia [2,0] == "X" || jogoDaVeia[0,2] == "X" && jogoDaVeia [2,0] == "X")
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[1,1] = "X";
			}
		}
		else if(bolaOuX == "X")
		{
			// Condição para a primeira linha  
			if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@" || jogoDaVeia[0,1] == "@" && jogoDaVeia [0,2] == "@" || jogoDaVeia[0,0] == "@" && jogoDaVeia [0,2] == "@")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [0,2] == "@")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,2] == "@")
					jogoDaVeia[0,1] = "@";
			}
			// Condição para a segunda linha   
			else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@" || jogoDaVeia[1,1] == "@" && jogoDaVeia [1,2] == "@" || jogoDaVeia[1,0] == "@" && jogoDaVeia [1,2] == "@")
			{
				if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[1,2] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[1,0] = "@";
				else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[1,1] = "@";
			}
			// Condição para a terceira linha   
			else if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@" || jogoDaVeia[2,1] == "@" && jogoDaVeia [2,2] == "@" || jogoDaVeia[2,0] == "@" && jogoDaVeia [2,2] == "@")
			{
				if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[2,1] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[2,1] = "@";
			}
			// Condição para a primeira coluna       
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@" || jogoDaVeia[1,0] == "@" && jogoDaVeia [2,0] == "@" || jogoDaVeia[0,0] == "@" && jogoDaVeia [2,0] == "@")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@")
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[1,0] = "@";
			}
			// Condição para a segunda coluna  
			else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@" || jogoDaVeia[1,1] == "@" && jogoDaVeia [2,1] == "@" || jogoDaVeia[0,1] == "@" && jogoDaVeia [2,1] == "@")
			{
				if(jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,1] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[0,1] = "@";
				else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[1,1] = "@";
			}
			// Condição para a terceira coluna  
			else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@" || jogoDaVeia[1,2] == "@" && jogoDaVeia [2,2] == "@" || jogoDaVeia[0,2] == "@" && jogoDaVeia [2,2] == "@")
			{
				if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[1,2] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[1,2] = "@";
			}
			// Condição para a primeira diagonal       
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@" || jogoDaVeia[1,1] == "@" && jogoDaVeia [2,2] == "@" || jogoDaVeia[0,0] == "@" && jogoDaVeia [2,2] == "@")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[1,1] = "@";
			}
			// Condição para a segunda diagonal  
			else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@" || jogoDaVeia[1,1] == "@" && jogoDaVeia [2,0] == "@" || jogoDaVeia[0,2] == "@" && jogoDaVeia [2,0] == "@")
			{
				if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[1,1] = "@";
			}
		}
	}
	static void IAO(string[,] jogoDaVeia, string position, string bolaOuX)
	{
		Random rnd = new Random();	
		if(bolaOuX == "@")
		{
	//Posição 1
			#region Condição posição 1
			if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,2] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[2,0] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,2] == "X")
					jogoDaVeia[2,0] = "X";
			}
			else if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia[2,0] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia[2,2] == "X")
					jogoDaVeia[0,2] = "X";
			}
			else if(((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))  ||  ((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[2,0] =="X")
				{
					if(jogoDaVeia[2,1] == "@")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[1,2] == "@")
						jogoDaVeia[2,1] = "X";
				}
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia[2,2] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[2,1] == "@")
				{
					if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[1,2] == "@")
						jogoDaVeia[1,1] = "X";
				}
			}
			else if(((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")  || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))   ||   ((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] != "9")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))  ||  (((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")) || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);

			}
			#endregion	

	//Posição 2
			#region Condição posição 2
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0]=="X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[0,2] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,0]=="X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[2,2]=="X")
					jogoDaVeia[0,2] = "X";
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0]== "X" && jogoDaVeia[2,0]=="X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia[2,2] == "X")
					jogoDaVeia[2,0] = "X";
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))  ||  
			((jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[2,0] =="X")
				{
					if(jogoDaVeia[1,1] =="@")
						jogoDaVeia[2,1] = "X";
					else
						jogoDaVeia[1,1] = "X";
				}
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia[2,2] == "X" && jogoDaVeia[2,0] == "X")
				{
					if(jogoDaVeia[1,1] =="@")
						jogoDaVeia[2,1] = "X";
					else
						jogoDaVeia[1,1] = "X";				
				}
			}
			else if(((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")  || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "X"))   ||   ((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] != "9")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))  ||  (((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")) || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			#endregion

	//Posição 3
			#region Condição posição 3
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[2,0] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,2] == "X")
					jogoDaVeia[2,0] = "X";
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[2,0] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia[2,2] == "X")
					jogoDaVeia[0,0] = "X";
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))  ||  ((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[2,0] =="X")
				{
					if(jogoDaVeia[2,1] == "@")
						jogoDaVeia[1,1] = "X";
					else if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[2,1] = "X";
				}
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia[2,2] == "X" && jogoDaVeia[0,0] == "X" && jogoDaVeia[2,1] == "@")
				{
					if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[1,0] = "X";
					else if(jogoDaVeia[1,0] == "@")
						jogoDaVeia[1,1] = "X";
				}
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] != "9"))   ||   ((jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))  ||  (((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")) || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			#endregion	

	//Posição 4
			#region Condição posição 4
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0]=="X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[2,0]=="X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,2]=="X")
					jogoDaVeia[2,0] = "X";
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0]== "X" && jogoDaVeia[0,2]=="X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia[2,2] == "X")
					jogoDaVeia[0,2] = "X";
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))  ||  
			((jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia[2,2] =="X")
				{
					if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[1,2] == "@")
						jogoDaVeia[1,1] = "X";
				}
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] != "9"))   ||   ((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "X"))  ||  (((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")) || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			#endregion

	//Posição 5
			#region Condição posição 5
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					int numrand = rnd.Next(6,9);
					if(numrand == 6)
						jogoDaVeia[1,2] = "X";
					else if(numrand == 8)
						jogoDaVeia[2,1] = "X";
					else if(numrand == 9)
						jogoDaVeia[2,2] = "X";
					else
						jogoDaVeia[1,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					int numrand = rnd.Next(4,8);
					if(numrand == 4)
						jogoDaVeia[1,0] = "X";
					else if(numrand == 7)
						jogoDaVeia[2,0] = "X";
					else if(numrand == 8)
						jogoDaVeia[2,1] = "X";
					else
						jogoDaVeia[1,2] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					int numrand = rnd.Next(2,6);
					if(numrand == 2)
						jogoDaVeia[0,1] = "X";
					else if(numrand == 3)
						jogoDaVeia[0,2] = "X";
					else if(numrand == 6)
						jogoDaVeia[1,2] = "X";
					else
						jogoDaVeia[1,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
				{
					int numrand = rnd.Next(1,4);
					if(numrand == 1)
						jogoDaVeia[0,0] = "X";
					else if(numrand == 2)
						jogoDaVeia[0,1] = "X";
					else if(numrand == 4)
						jogoDaVeia[1,0] = "X";
					else
						jogoDaVeia[1,2] = "X";
				}
			}
			else if( /*1*/( (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") ) || /*3*/( (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") ) || /*7*/( (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") ) || /*9*/( (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") ) )
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[0,2] = "X";
				}
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[2,0] = "X";					
				}
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
					{
						jogoDaVeia[0,2] = "X";
					}
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
					{
						jogoDaVeia[2,0] = "X";
					}
				}
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[0,2] = "X";
				}
				//3
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
				{
					jogoDaVeia[0,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
				{
					if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
					{
						jogoDaVeia[2,2] = "X";
					}
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
					{
						jogoDaVeia[0,0] = "X";
					}
				}
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[2,2] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
				{
					jogoDaVeia[0,0] = "X";
				}
				//7
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
				{
					if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
					{
						jogoDaVeia[2,2] = "X";
					}
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
					{
						jogoDaVeia[0,0] = "X";
					}
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[0,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[2,2] = "X";					
				}
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[2,2] = "X";
				}
				//9
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
					{
						jogoDaVeia[2,0] = "X";
					}
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
					{
						jogoDaVeia[0,2] = "X";
					}
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
				{
					jogoDaVeia[0,2] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
				{
					jogoDaVeia[2,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
				{
					jogoDaVeia[2,0] = "X";
				}
			}
			else if( ( (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") ) || /*3*/( (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") ) || /*7*/( (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") ) || /*9*/( (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") ) )
			{
				if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@"))
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
						jogoDaVeia[2,2] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[0,1] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
						jogoDaVeia[2,2] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[0,1] = "X";
				}
				else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@"))
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9")
						jogoDaVeia[2,2] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[1,0] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[2,2] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[1,0] = "X";
				}
				else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,1] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
				{
					jogoDaVeia[2,1] = "X";					
				}
				//3
				else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@"))
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
						jogoDaVeia[2,0] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
						jogoDaVeia[0,1] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[2,0] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[0,1] = "X";
				}
				else if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@"))
				{
					if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";
					else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[1,0] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[0,1] = "X";
				}
				else if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X"))
				{
					if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,0] = "X";
					else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,0] = "X";						
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";
				}
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
				{
					Console.WriteLine("ujwegfhuwgu");
					jogoDaVeia[2,1] = "X";					
				}
				//7
				else if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@"))
				{
					if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";
					else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[1,0] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[0,1] = "X";
				}
				else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9"))
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[1,0] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[0,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")
						jogoDaVeia[0,2] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9")
						jogoDaVeia[1,0] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9")
						jogoDaVeia[0,2] = "X";
				}
				else if((jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
				{
					if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,2] = "X";
					else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";						
					else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,2] = "X";
				}
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
				{
						jogoDaVeia[0,1] = "X";					
				}
				//9
				else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
				{
					if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";						
					else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,1] = "X";
				}
				else if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
				{
					if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,0] = "X";
					else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[1,2] = "X";						
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,0] = "X";
				}
				else if((jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X" || jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
				{
					if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,0] = "X";
					else if(jogoDaVeia[0,0] == "@" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[2,1] = "X";						
					else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
						jogoDaVeia[0,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "@" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")
				{
						jogoDaVeia[0,1] = "X";					
				}
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  
			
			||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  
			
			||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  
			
			||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{

			}

		#endregion

	//Posição 6
			#region Condição posição 6
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0]=="X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[2,0]=="X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,2]=="X")
					jogoDaVeia[2,0] = "X";
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0]== "X" && jogoDaVeia[0,2]=="X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia[2,2] == "X")
					jogoDaVeia[0,0] = "X";
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9"))  ||  
			((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[2,0] =="X")
				{
					if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[1,0] = "X";
					else if(jogoDaVeia[1,0] == "@")
						jogoDaVeia[1,1] = "X";
				}
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] != "9"))   ||   ((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] != "9"))  ||  (((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")) || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			#endregion			

	//Posição 7
			#region Condição posição 7
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0] == "X") 
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X")
					jogoDaVeia[0,0] = "X";
				else if( jogoDaVeia[2,2] == "X")
					jogoDaVeia[0,2] = "X";
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,2] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia[2,2] == "X")
					jogoDaVeia[0,0] = "X";
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))  ||  ((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")))
			{
				
				if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
				{
					if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[1,2] = "X";
					else if(jogoDaVeia[1,2] == "@")
						jogoDaVeia[1,1] = "X";
				}
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[2,2] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,2] == "@")
				{
					if(jogoDaVeia[0,1] == "@")
						jogoDaVeia[1,1] = "X";
					else if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[0,1] = "X";
				}
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] != "9"))   ||   ((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "X"))  ||  (((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X")) || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "@" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			#endregion			

	//Posição 8
			#region Condição posição 8
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0]=="X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[0,2] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,0]=="X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[2,2]=="X")
					jogoDaVeia[0,2] = "X";
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[2,0] == "X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia[2,2] == "X")
					jogoDaVeia[0,0] = "X";
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9"))  ||  
			((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,2] =="X")
				{
					if(jogoDaVeia[0,1] == "@")
						jogoDaVeia[1,1] = "X";
					else if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[0,1] = "X";
				}
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9")  || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] != "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] != "9"))   ||   ((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] != "9"))  ||  (((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")) || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "@" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] == "@" && jogoDaVeia[2,2] == "X")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			#endregion	

	//Posição 9
			#region Condição posição 9
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@"))
			{
				if(jogoDaVeia[0,0] == "X") 
				{
					jogoDaVeia[0,2] = "X";
				}
				else if(jogoDaVeia[0,2] == "X")
				{
					jogoDaVeia[0,0] = "X";
				}
				else if( jogoDaVeia[2,0] == "X")
				{
					jogoDaVeia[0,2] = "X";
				}
			}
			else if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@"))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,2] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia[0,2] == "X")
					jogoDaVeia[0,0] = "X";
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@"))  ||  ((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "@" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")))
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,2] =="X" && jogoDaVeia[0,1] =="@")
				{
					if(jogoDaVeia[1,0] == "@")
						jogoDaVeia[1,1] = "X";
					else if(jogoDaVeia[1,1] == "@")
						jogoDaVeia[1,0] = "X";
				}
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia[0,2] == "X" && jogoDaVeia[2,0] == "X" && jogoDaVeia[1,1] == "@")
				{
					if(jogoDaVeia[0,1] == "@")
						jogoDaVeia[1,0] = "X";
					else if(jogoDaVeia[1,0] == "@")
						jogoDaVeia[0,1] = "X";
				}
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")  || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] != "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] != "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "@"))   ||   ((jogoDaVeia[0,0] != "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] != "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] != "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "@")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			else if(((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@") || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "@" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "@"))  ||  (((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] != "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "@")) || (jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "@" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] != "8" && jogoDaVeia[2,2] == "@")))
			{	
				Condiçoes(jogoDaVeia, bolaOuX);
			}
			#endregion	

			#region ATAQUE
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X" && jogoDaVeia [0,2] == "1" || jogoDaVeia[0,1] == "X" && jogoDaVeia [0,2] == "X" && jogoDaVeia [0,0] == "3"|| jogoDaVeia[0,0] == "X" && jogoDaVeia [0,2] == "X" && jogoDaVeia [0,1] == "2")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [0,2] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,2] == "X")
					jogoDaVeia[0,1] = "X";
			}  
			else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [1,2] == "6"|| jogoDaVeia[1,1] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [1,0] == "4"|| jogoDaVeia[1,0] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[1,2] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[1,0] = "X";
				else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[1,1] = "X";
			}
			else if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[2,1] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[2,0] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [2,1] == "8")
			{
				if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,1] == "X" && jogoDaVeia [2,2] == "X")	
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[2,1] = "X";
				
			}   
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X" && jogoDaVeia [2,0] == "7" || jogoDaVeia[1,0] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [0,0] == "1" || jogoDaVeia[0,0] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [1,0] == "4")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[1,0] = "X";
			}
			else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,1] == "8" || jogoDaVeia[1,1] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [0,1] == "2"|| jogoDaVeia[0,1] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,1] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[0,1] = "X";
				else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[1,1] = "X";
			}
			else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,2] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [1,2] == "6")
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[1,2] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[1,2] = "X";
			}    
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,1] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [0,0] == "1"|| jogoDaVeia[0,0] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[1,1] = "X";
			}
			else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[1,1] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[1,1] = "X";
			}
			#endregion

			#region DEFESA
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@" && jogoDaVeia [0,2] == "1" || jogoDaVeia[0,1] == "@" && jogoDaVeia [0,2] == "@" && jogoDaVeia [0,0] == "3"|| jogoDaVeia[0,0] == "@" && jogoDaVeia [0,2] == "@" && jogoDaVeia [0,1] == "2")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [0,2] == "@")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,2] == "@")
					jogoDaVeia[0,1] = "X";
			}  
			else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [1,2] == "6"|| jogoDaVeia[1,1] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [1,0] == "4"|| jogoDaVeia[1,0] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[1,2] = "X";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[1,0] = "X";
				else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[1,1] = "X";
			}
			else if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[2,1] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[2,0] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [2,1] == "8")
			{
				if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[2,1] == "@" && jogoDaVeia [2,2] == "@")	
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[2,1] = "X";
			}   
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@" && jogoDaVeia [2,0] == "7" || jogoDaVeia[1,0] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [0,0] == "1" || jogoDaVeia[0,0] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [1,0] == "4")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[1,0] = "X";
			}
			else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,1] == "8" || jogoDaVeia[1,1] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [0,1] == "2"|| jogoDaVeia[0,1] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,1] = "X";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[0,1] = "X";
				else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[1,1] = "X";
			}
			else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,2] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [1,2] == "6")
			{
				if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[1,2] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[1,2] = "X";
			}    
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,1] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [0,0] == "1"|| jogoDaVeia[0,0] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,2] = "X";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[0,0] = "X";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[1,1] = "X";
			}
			else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[1,1] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,0] = "X";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[0,2] = "X";
				else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[1,1] = "X";
			}
			#endregion	

			#region COMPLETA
			else if(jogoDaVeia[0,0] != "X" &&  jogoDaVeia[0,0] != "@")
			{
				jogoDaVeia[0,0] = "X";
			}
			else if(jogoDaVeia[0,1] != "X" &&  jogoDaVeia[0,1] != "@")
			{
				jogoDaVeia[0,1] = "X";
			}
			else if(jogoDaVeia[0,2] != "X" &&  jogoDaVeia[0,2] != "@")
			{
				jogoDaVeia[0,2] = "X";
			}
			else if(jogoDaVeia[1,0] != "X" &&  jogoDaVeia[1,0] != "@")
			{
				jogoDaVeia[1,0] = "X";
			}
			else if(jogoDaVeia[1,1] != "X" &&  jogoDaVeia[1,1] != "@")
			{
				jogoDaVeia[1,1] = "X";
			}
			else if(jogoDaVeia[1,2] != "X" &&  jogoDaVeia[1,2] != "@")
			{
				jogoDaVeia[1,2] = "X";
			}
			else if(jogoDaVeia[2,0] != "X" &&  jogoDaVeia[2,0] != "@")
			{
				jogoDaVeia[2,0] = "X";
			}
			else if(jogoDaVeia[2,1] != "X" &&  jogoDaVeia[2,1] != "@")
			{
				jogoDaVeia[2,1] = "X";
			}
			else if(jogoDaVeia[2,2] != "X" &&  jogoDaVeia[2,2] != "@")
			{
				jogoDaVeia[2,2] = "X";
			}
			#endregion	
		}
		else if(bolaOuX == "X")
		{
			if((jogoDaVeia[0,0] == "X" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "X" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")  ||  (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "X" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "X" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "X" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "X" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "X" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "X" && jogoDaVeia[2,2] == "9") || (jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "X"))
			{
				if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "X" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
					jogoDaVeia[0,0] = "@";
				else
					jogoDaVeia[1,1] = "@";
			}

			#region ATAQUE
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@" && jogoDaVeia [0,2] == "1" || jogoDaVeia[0,1] == "@" && jogoDaVeia [0,2] == "@" && jogoDaVeia [0,0] == "3"|| jogoDaVeia[0,0] == "@" && jogoDaVeia [0,2] == "@" && jogoDaVeia [0,1] == "2")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [0,2] == "@")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [0,2] == "@")
					jogoDaVeia[0,1] = "@";
			}  
			else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [1,2] == "6"|| jogoDaVeia[1,1] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [1,0] == "4"|| jogoDaVeia[1,0] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[1,2] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[1,0] = "@";
				else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[1,1] = "@";
			}
			else if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[2,1] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[2,0] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [2,1] == "8")
			{
				if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[2,1] == "@" && jogoDaVeia [2,2] == "@")	
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[2,0] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[2,1] = "@";
				
			}   
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@" && jogoDaVeia [2,0] == "7" || jogoDaVeia[1,0] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [0,0] == "1" || jogoDaVeia[0,0] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [1,0] == "4")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@")
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[1,0] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[1,0] = "@";
			}
			else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,1] == "8" || jogoDaVeia[1,1] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [0,1] == "2"|| jogoDaVeia[0,1] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,1] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[0,1] = "@";
				else if(jogoDaVeia[0,1] == "@" && jogoDaVeia [2,1] == "@")
					jogoDaVeia[1,1] = "@";
			}
			else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,2] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [1,2] == "6")
			{
				if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[1,2] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[1,2] = "@";
			}    
			else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,1] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [0,0] == "1"|| jogoDaVeia[0,0] == "@" && jogoDaVeia [2,2] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "@" && jogoDaVeia [2,2] == "@")
					jogoDaVeia[1,1] = "@";
			}
			else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[1,1] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "@" && jogoDaVeia [2,0] == "@" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@")
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[1,1] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,2] == "@" && jogoDaVeia [2,0] == "@")
					jogoDaVeia[1,1] = "@";
			}
			#endregion

			#region DEFESA
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X" && jogoDaVeia [0,2] == "1" || jogoDaVeia[0,1] == "X" && jogoDaVeia [0,2] == "X" && jogoDaVeia [0,0] == "3"|| jogoDaVeia[0,0] == "X" && jogoDaVeia [0,2] == "X" && jogoDaVeia [0,1] == "2")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [0,2] == "X")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [0,2] == "X")
					jogoDaVeia[0,1] = "@";
			}  
			else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [1,2] == "6"|| jogoDaVeia[1,1] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [1,0] == "4"|| jogoDaVeia[1,0] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[1,2] = "@";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[1,0] = "@";
				else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[1,1] = "@";
			}
			else if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[2,1] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[2,0] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [2,1] == "8")
			{
				if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[2,1] == "X" && jogoDaVeia [2,2] == "X")	
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[2,0] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[2,1] = "@";
			}   
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X" && jogoDaVeia [2,0] == "7" || jogoDaVeia[1,0] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [0,0] == "1" || jogoDaVeia[0,0] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [1,0] == "4")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X")
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[1,0] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[1,0] = "@";
			}
			else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,1] == "8" || jogoDaVeia[1,1] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [0,1] == "2"|| jogoDaVeia[0,1] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,1] = "@";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[0,1] = "@";
				else if(jogoDaVeia[0,1] == "X" && jogoDaVeia [2,1] == "X")
					jogoDaVeia[1,1] = "@";
			}
			else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,2] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [1,2] == "6")
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[1,2] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[1,2] = "@";
			}    
			else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,2] == "9"|| jogoDaVeia[1,1] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [0,0] == "1"|| jogoDaVeia[0,0] == "X" && jogoDaVeia [2,2] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,2] = "@";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[0,0] = "@";
				else if(jogoDaVeia[0,0] == "X" && jogoDaVeia [2,2] == "X")
					jogoDaVeia[1,1] = "@";
			}
			else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,0] == "7"|| jogoDaVeia[1,1] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [0,2] == "3"|| jogoDaVeia[0,2] == "X" && jogoDaVeia [2,0] == "X" && jogoDaVeia [1,1] == "5")
			{
				if(jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X")
					jogoDaVeia[2,0] = "@";
				else if(jogoDaVeia[1,1] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[0,2] = "@";
				else if(jogoDaVeia[0,2] == "X" && jogoDaVeia [2,0] == "X")
					jogoDaVeia[1,1] = "@";
			}
			#endregion	

			#region COMPLETA
			else if(jogoDaVeia[0,0] != "X" &&  jogoDaVeia[0,0] != "@")
			{
				jogoDaVeia[0,0] = "@";
			}
			else if(jogoDaVeia[0,1] != "X" &&  jogoDaVeia[0,1] != "@")
			{
				jogoDaVeia[0,1] = "@";
			}
			else if(jogoDaVeia[0,2] != "X" &&  jogoDaVeia[0,2] != "@")
			{
				jogoDaVeia[0,2] = "@";
			}
			else if(jogoDaVeia[1,0] != "X" &&  jogoDaVeia[1,0] != "@")
			{
				jogoDaVeia[1,0] = "@";
			}
			else if(jogoDaVeia[1,1] != "X" &&  jogoDaVeia[1,1] != "@")
			{
				jogoDaVeia[1,1] = "@";
			}
			else if(jogoDaVeia[1,2] != "X" &&  jogoDaVeia[1,2] != "@")
			{
				jogoDaVeia[1,2] = "@";
			}
			else if(jogoDaVeia[2,0] != "X" &&  jogoDaVeia[2,0] != "@")
			{
				jogoDaVeia[2,0] = "@";
			}
			else if(jogoDaVeia[2,1] != "X" &&  jogoDaVeia[2,1] != "@")
			{
				jogoDaVeia[2,1] = "@";
			}
			else if(jogoDaVeia[2,2] != "X" &&  jogoDaVeia[2,2] != "@")
			{
				jogoDaVeia[2,2] = "@";
			}
			#endregion	
		}
	}
	public static void Main (string[] args) 
	{
		int vitoria = 0;
		string position = "0";
		string[,] jogoDaVeia = new string[3, 3] { { "1", "2", "3"}, 
												  { "4", "5", "6"}, 
												  { "7", "8", "9"} };
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.DarkMagenta;
		Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t  BEM VINDO AO JOGO DA VELHA!");
		Console.WriteLine();
		string jogarDeNovo = "sim";
		while(jogarDeNovo.ToUpper() == "SIM")
		{
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.Write("\t\t\t\t\t\t\t\t\t\t\t\tNesse jogo o "); 
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("(X)"); 
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine(" sempre começará!"); 
			Console.WriteLine();
			Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\tVocê deseja ser: \n\t\t\t\t\t\t\t\t\t\t\t\t o "); 
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write("'Bolinha'(@)");
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.Write(" ou o "); 
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("'Xis'(X)");
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.Write("? ");
			Console.ResetColor(); 
			Console.SetCursorPosition((Console.CursorLeft - 16),(Console.CursorTop + 2));
			string bolaOuX = Console.ReadLine().ToUpper();
			Console.Clear();

			while(bolaOuX.ToUpper() != "@" && bolaOuX.ToUpper() != "X")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t RESPOSTA INVÁLIDA!");
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.DarkMagenta;
				Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t  Você deseja ser: \n\t\t\t\t\t\t\t\t\t\t\t\t   o "); 
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.Write("'Bolinha'(@)");
				Console.ForegroundColor = ConsoleColor.DarkMagenta;
				Console.Write(" ou o "); 
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write("'Xis'(X)");
				Console.ForegroundColor = ConsoleColor.DarkMagenta;
				Console.Write("? ");
				Console.SetCursorPosition(63,6); 
				bolaOuX = Console.ReadLine().ToUpper();
				Console.Clear();
			}
			while(vitoria != 1 && vitoria != -1)
			{	
				if(bolaOuX == "@")
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t    A MÁQUINA COMEÇARÁ!");
					Console.WriteLine();
					Random rnd = new Random();
					if(jogoDaVeia[0,0] == "1" && jogoDaVeia[0,1] == "2" && jogoDaVeia[0,2] == "3" && jogoDaVeia[1,0] == "4" && jogoDaVeia[1,1] == "5" && jogoDaVeia[1,2] == "6" && jogoDaVeia[2,0] == "7" && jogoDaVeia[2,1] == "8" && jogoDaVeia[2,2] == "9")
					{
						int numrand = rnd.Next(1,5);
						if(numrand == 1)
							jogoDaVeia[0,0] = "X";
						else if(numrand == 2)
							jogoDaVeia[0,2] = "X";
						else if(numrand == 1)
							jogoDaVeia[2,0] = "X";
						else
							jogoDaVeia[2,2] = "X";
					}
					MostrarJogo(jogoDaVeia);
					Console.WriteLine();	
					Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\tEscolha uma posição: ");
					position = Console.ReadLine();
					while(position != "1" && position != "2" && position != "3" && position != "4" && position != "5" && position != "6" && position != "7" && position != "8" && position != "9")
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t     POSIÇÃO INVÁLIDA!");
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.DarkMagenta;
						MostrarJogo(jogoDaVeia);
						Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\tEscolha uma posição: ");
						position = Console.ReadLine();
					}
					Console.Clear();

					int posicaoMarcada = 0;
					posicaoMarcada = Jogador(position, jogoDaVeia, bolaOuX);
					if(posicaoMarcada == 0)
						IAO(jogoDaVeia, position, bolaOuX);
					vitoria = VerificaVitoria(jogoDaVeia);
				}
				else if(bolaOuX.ToUpper() == "X")
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t       VOCÊ COMEÇARÁ!");
					Console.WriteLine();
					MostrarJogo(jogoDaVeia);
					Console.WriteLine();	
					Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\tEscolha uma posição: ");
					position = Console.ReadLine();
					while(position != "1" && position != "2" && position != "3" && position != "4" && position != "5" && position != "6" && position != "7" && position != "8" && position != "9")
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t     POSIÇÃO INVÁLIDA!");
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.DarkMagenta;
						MostrarJogo(jogoDaVeia);
						Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\tEscolha uma posição: ");
						position = Console.ReadLine();
					}
					Console.Clear();

					int posicaoMarcada = 0;
					posicaoMarcada = Jogador(position, jogoDaVeia, bolaOuX);
					if(posicaoMarcada == 0)
						IAO(jogoDaVeia, position, bolaOuX);
					vitoria = VerificaVitoria(jogoDaVeia);
				}
			}
			Console.Clear();
			if(bolaOuX == "@")
			{
				if((jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@" && jogoDaVeia [0,2] == "@") || (jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [1,2] == "@") || (jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@" && jogoDaVeia [2,0] == "@") || (jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,1] == "@") || (jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,2] == "@") || (jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,0] == "@"))
				{
					Console.ForegroundColor = ConsoleColor.DarkGreen;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   PARABÉNS VOCÊ GANHOU!!");
				}
				else if((jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X" && jogoDaVeia [0,2] == "X") || (jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [1,2] == "X") || (jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X" && jogoDaVeia [2,0] == "X") || (jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,1] == "X") || (jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,2] == "X") || (jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,0] == "X"))
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   VOCÊ PERDEU!!");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tDEU VELHA!");
				}
			}
			else
			{
				if((jogoDaVeia[0,0] == "X" && jogoDaVeia [0,1] == "X" && jogoDaVeia [0,2] == "X") || (jogoDaVeia[1,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [1,2] == "X") || (jogoDaVeia[2,0] == "X" && jogoDaVeia [2,1] == "X" && jogoDaVeia [2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia [1,0] == "X" && jogoDaVeia [2,0] == "X") || (jogoDaVeia[0,1] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,1] == "X") || (jogoDaVeia[0,2] == "X" && jogoDaVeia [1,2] == "X" && jogoDaVeia [2,2] == "X") || (jogoDaVeia[0,0] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,2] == "X") || (jogoDaVeia[0,2] == "X" && jogoDaVeia [1,1] == "X" && jogoDaVeia [2,0] == "X"))
				{
					Console.ForegroundColor = ConsoleColor.DarkGreen;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tPARABÉNS VOCÊ GANHOU!!");
				}
				else if((jogoDaVeia[0,0] == "@" && jogoDaVeia [0,1] == "@" && jogoDaVeia [0,2] == "@") || (jogoDaVeia[1,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [1,2] == "@") || (jogoDaVeia[2,0] == "@" && jogoDaVeia [2,1] == "@" && jogoDaVeia [2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia [1,0] == "@" && jogoDaVeia [2,0] == "@") || (jogoDaVeia[0,1] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,1] == "@") || (jogoDaVeia[0,2] == "@" && jogoDaVeia [1,2] == "@" && jogoDaVeia [2,2] == "@") || (jogoDaVeia[0,0] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,2] == "@") || (jogoDaVeia[0,2] == "@" && jogoDaVeia [1,1] == "@" && jogoDaVeia [2,0] == "@"))
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   VOCÊ PERDEU!!");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tDEU VELHA!");
				}
			}
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			MostrarJogo(jogoDaVeia);
			int k = 1;
			for(int i = 0; i < 3; i++)
			{
				for(int j = 0; j < 3; j++)
				{
					jogoDaVeia[i, j] = Convert.ToString(k);
					k++;
				}
			}
			Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t  Deseja jogar de novo?\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t   Sim ou Não? ");
			jogarDeNovo = Console.ReadLine();
			if(jogarDeNovo.ToUpper() == "SIM")
				vitoria=0;
			Console.Clear();
			while(jogarDeNovo.ToUpper() != "SIM" && jogarDeNovo.ToUpper() != "NÃO" && jogarDeNovo.ToUpper() != "NAO")
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t RESPOSTA INVÁLIDA!");
				Console.WriteLine();
				Console.ResetColor();
				Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t  Deseja jogar de novo?\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t   Sim ou Não ?");
				jogarDeNovo = Console.ReadLine();
				if(jogarDeNovo.ToUpper() == "SIM")
					vitoria=0;
				Console.Clear();
			}
		}
		Console.ForegroundColor = ConsoleColor.DarkMagenta;		
		Console.WriteLine("Obrigado por jogar! :)");
	}
}