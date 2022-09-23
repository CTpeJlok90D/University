class Box:
    def __init__(self,a,b):
        self.a = a
        self.b = b

    def GetSquare(self):
        return self.a * self.b * 2

    def GetPerimetr(self):
        return (self.a + self.b)*2
