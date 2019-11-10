import numpy as np

def pesquisa_binaria(lista, item):
    baixo = 0
    alto = len(lista) - 1
    saltos = 1
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

    
# minha_lista = [1,2, 3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,29,30,31,32,33,34,35]
minha_lista = np.arange(1,128)

print("pesquisa binária: Aqui ele precisou de 3 tentativas para encontrar o numero.")
print(pesquisa_binaria(minha_lista, 22))




