            //Removes the beginning characters from 0 to defined index, and them trims the spaces from both side           
            public string GetTextAfterRemovingASubString()
            {
                 StringBuilder sb = new StringBuilder(textString);
                 return sb.Remove(0, indexOfAnCharacter).ToString().Trim();
            }

            // Retrive the fields of a class and retrive the assigned values there
            public void AccessTheFieldValuesOfAClass()
            {
            Type type = typeof(ClassABC);
             //To Retrive the properties of a class we can user PropertyInfo and GetProperty()
            foreach (FieldInfo field in type.GetFields())
            {
               //To Get The Name Of field and not the assigned value there we can user field.Name
               ApplicationHelper.VerifyLabelExit(testControl, field.GetValue(null).ToString());
            }
        }
