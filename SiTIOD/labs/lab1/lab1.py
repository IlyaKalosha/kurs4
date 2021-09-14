"""переменные"""

first_var = 1
second_var = 2

result = first_var + second_var
print(result)

"""строки"""
first_string = 'abc'
second_string = 'def'

result_string = first_string + second_string
print(result_string)

"""списки"""

first_arr = [1, 2, 3, 4]
second_arr = [6, 7, 8, 'etc']
var_to_extend = 5

first_arr.append(var_to_extend)
first_arr.extend(second_arr)

print(first_arr)

"""кортежи"""

first_tuple = (1, 2, 3, 4)
single_item_tuple = (9,)

print(first_tuple)
print(single_item_tuple)

"""словари"""

first_dict = {
				'key1':'value1',
				'key2':'value2',
				'key3':'value3'
			}
print(first_dict)
print(first_dict.keys())
print(first_dict.values())