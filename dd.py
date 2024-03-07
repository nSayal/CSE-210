# Define the Person class
class Person:

    def __init__(self, name="", month_of_birth="", day_of_birth="", year_of_birth=""):
        self.name = name
        self.month_of_birth = month_of_birth
        self.day_of_birth = day_of_birth
        self.year_of_birth = year_of_birth

    def get_information(self):
        self.name = input("Enter the name: ")
        self.month_of_birth = input("Enter the month of birth: ")
        self.day_of_birth = input("Enter the day of birth: ")
        self.year_of_birth = input("Enter the year of birth: ")

    def show_information(self):
        print(self.name)
        print(self.month_of_birth)
        print(self.day_of_birth)
        print(self.year_of_birth)

# Create an instance of the Person class
Person1 = Person()

# Get information from user input
Person1.get_information()

# Display the information
Person1.show_information()
