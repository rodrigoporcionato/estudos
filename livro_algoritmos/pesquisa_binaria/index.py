
def pesquisa_linear(lista, item):
    baixo = 0
    alto = len(lista)
    saltos = 0
    while baixo <= alto:
        saltos = saltos + 1                
        
        if baixo == item:
            print("total de saltos: " + str(saltos))
            return item          
        else:
            baixo = baixo + 1


def pesquisa_binaria(lista, item):
    baixo = 0
    alto = len(lista) - 1
    saltos = 0
    while baixo <= alto:
        saltos = saltos + 1        
        meio = (baixo + alto) // 2
        chute = lista[meio]
        if chute == item:
            print("total de saltos: " + str(saltos))
            return meio            
        if chute > item:
            alto = meio - 1
        else:
            baixo = meio + 1    
    print("total de saltos: " + str(saltos))
    return None

    
minha_lista = [1,2, 3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,29,30,31,32,33,34,35]

print("pesquisa binária: Aqui ele precisou de 3 tentativas para encontrar o numero.")
print(pesquisa_binaria(minha_lista, 22))

print("Neste exemplo, a pesquisa simples iria percorrer 22 vezes até encontrar o numero.")
print(pesquisa_linear(minha_lista, 22))

