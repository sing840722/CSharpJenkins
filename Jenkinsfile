def getGitBranchName() {
    return scm.branches[0].name
}

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
				checkout scm
			}
        }
    }
	post {
	always{
		echo 'I have Finished'
		}
	}
}