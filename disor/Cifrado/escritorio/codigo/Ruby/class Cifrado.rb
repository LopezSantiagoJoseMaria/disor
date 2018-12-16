class Cifrado
 
  def initialize()
    puts "Escribe el texto a encriptar"
    @texto = gets.chomp

  end
 
 

  def cifra()
  	n=3
  	resultado= ''
	
	@texto.each_char do |letra|
		
		n.times {letra=letra.next[0]} 
		
		if letra.match(/[a-z A-Z]/)
			resultado << letra

		end
	end
	puts "El texto encriptado es: #{resultado}"
  end




end
 





cif = Cifrado.new()
cif.cifra