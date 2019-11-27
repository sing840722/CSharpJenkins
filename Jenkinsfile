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
                bat 'git checkout master'
				bat 'git merge origin/dev'
				bat 'git merge dev'
				bat 'git push origin master'
            }
        }
    }
}