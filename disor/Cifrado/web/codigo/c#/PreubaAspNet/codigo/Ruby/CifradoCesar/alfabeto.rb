class Alfabeto

  @@alfabeto

  def initialize
    @@alfabeto = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z','Á','É','Í','Ó','Ú','a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z','á','é','í','ó','ú']
  end

  def longitud
    return @@alfabeto.length
  end

  def existe?(caracter)
    return @@alfabeto.include? caracter
  end

  def caracterEn(indice)
    return @@alfabeto[indice]
  end

  def indiceDe(caracter)
    return @@alfabeto.index(caracter)
  end

end