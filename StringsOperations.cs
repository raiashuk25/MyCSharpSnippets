            public string GetTextAfterRemovingASubString()
            {
                 StringBuilder sb = new StringBuilder(textString);
                 return sb.Remove(0, indexOfAnCharacter).ToString().Trim();
            }
