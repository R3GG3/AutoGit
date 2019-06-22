@echo off
timeout 1
C:
timeout 1
cd C:\Users\konra\source\repos\Assistant
timeout 1
echo "# AutoGit" >> README.md
timeout 1
git config --global user.name "R3GG3"
timeout 1
git config --global user.email "konrad.soczi@gmail.com"
timeout 1
git init
timeout 1
git add .
timeout 1
git commit -m "Commit Made By Auto Git from R3GG3 and HiGh_SkUlL!"
timeout 1
git remote add origin https://github.com/R3GG3/Assistant.git
timeout 1
git push -u origin master
timeout 1
exit
