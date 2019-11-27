pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
				bat 'JenkinsTest.sln'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}