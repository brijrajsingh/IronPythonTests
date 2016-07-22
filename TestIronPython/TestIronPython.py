#import clr

##type defined generics, like Lists and dictionaries with support of their native functions 

#from System.Collections.Generic import List, Dictionary


#int_list = List[int]()
#int_list.Add(10)
#int_list.Add(20)
#int_list.Add(30)
#print(int_list)

#str_float_dict = Dictionary[str, float]()
#str_float_dict.Add("brij",10)
#print(str_float_dict)

########################################################
#myBaseClass = MyBaseClass()
#a = myBaseClass.SayHello()
#print(a)

#print (raw_input('Type whatever to end'))

#######reference a .net library and use it with python

import os
import sys
import clr

sys.path.append(os.getcwd())
clr.AddReference("netClassLib.dll")

import netClassLib

classObj = netClassLib.MyBaseClass()
print(classObj.SayHello())

print (raw_input('Type whatever to end'))
