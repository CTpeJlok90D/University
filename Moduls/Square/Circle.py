from cmath import pi

class Circle(object):
    def __init__(self,radius):
        self.radius = radius
    
    def GetSquare(self):
        return pi*self.radius**2

    def GetPerimetr(self):
        return pi*self.radius*2




