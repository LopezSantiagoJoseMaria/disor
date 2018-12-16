#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::setName(const QString &name)
{
 ui->lineEdit_2->setText(name);
}

QString MainWindow::name() const
{
 return ui->lineEdit_2->text();
}



QString MainWindow::getName() const
{
 return ui->lineEdit->text();
}
