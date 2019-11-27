pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
				bat 'dotnet build'
            }
        }
        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }
        stage('Deploy') {
            steps {
				bat 'git merge origin/dev'
				bat 'git config user.email "sing840722@gmail.com"'
				bat 'git config user.name "sing840722"'
				bat 'git push origin master'
            }
        }
    }
}