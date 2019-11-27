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
				echo 'Deploying...'
				git url: "ssh://jenkins@sing840722:sing840722/CSharpJenkins.git",
				credentialsId: 'sing840722',
				branch: dev
			}
        }
    }
	post {
	always{
		echo 'I have Finished'
		deleteDir()
		}
	}
}