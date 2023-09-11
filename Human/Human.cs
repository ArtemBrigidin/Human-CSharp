namespace Human
{
    public class Human
    {
        static int count = 0;
        string name;
        string gender;
        int age;
        Human mother;
        Human father;
        Human child;
        string family_member;
        public Human(string name, string gender, int age, Human mother, Human father, Human child)
        {
            count++;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.mother = mother;
            this.father = father;
            this.child = child;

        }

        public void SetParent(Human _father, Human _mother)
        {
            if (this.gender == "Мужской" && this.age < _father.age)
            {
                this.family_member = "Сын";
            }
            else if (this.gender == "Женский" && this.age < _father.age)
            {
                this.family_member = "Дочь";
            }

            father = _father;
            father.child = this;
            father.family_member = "Отец";

            mother = _mother;
            mother.child = this;
            mother.family_member = "Мать";
        }
        public void GetInfo()
        {
            Console.WriteLine($"{this.family_member} | Имя : {this.name}, Пол : {this.gender}, Возраст : {this.age}\n");
            if (this.father != null)
            {
                Console.WriteLine($"{this.father.family_member} | Имя : {this.father.name}, Пол : {this.father.gender}, Возраст : {this.father.age}\n");
            }
            if (this.mother != null)
            {
                Console.WriteLine($"{this.mother.family_member} | Имя : {this.mother.name}, Пол : {this.mother.gender}, Возраст : {this.mother.age}\n");
            }
            if (this.child != null)
            {
                Console.WriteLine($"{this.child.family_member} | Имя : {child.name}, Пол : {child.gender}, Возраст : {child.age}\n");
                if (this.child.father != null && this != this.child.father)
                    Console.WriteLine($"Муж | Имя : {child.father.name}, Пол : {child.father.gender}, Возраст:  {child.father.age}\n");

                if (this.child.mother != null && this != this.child.mother)
                    Console.WriteLine($"Жена | Имя : {child.mother.name}, Пол : {child.mother.gender}, Возраст : {child.mother.age}\n");
            }

        }

        public override string ToString()
        {
            string result = $"{this.family_member}  | Имя: {this.name}, Пол: {this.gender}, Возраст: {this.age}\n";

            if (this.father != null)
            {
                result += $"Отец | {this.father.name}\n";
            }
            if (this.mother != null)
            {
                result += $"Мать | {this.mother.name}\n";
            }
            if (this.child != null)
            {
                result += $"Сын | {this.child.name}\n";
            }
            if (this.child != null && this.child.father != null && this != this.child.father)
            {
                result += $"Муж | {this.child.father.name}";
            }
            if (this.child != null && this.child.mother != null && this != this.child.mother)
            {
                result += $"Жена | {this.child.mother.name}";
            }
            return result;
        }
    }
}